const colorVariant = ["Faded", "Bordered", "Light"];

function getHex(color) {
    const list = {
        Default: "#3f3f46",
        Primary: "#006FEE",
        Secondary: "#9353d3",
        Success: "#17c964",
        Warning: "#f5a524",
        Danger: "#f31260"
    };
    return list[color] || "#3f3f46";
}

function rippleBtn(e) {
    const { clientX, clientY } = e;

    const rippleElement = document.createElement('span');
    rippleElement.classList.add('ripple');

    const colorHex = getHex(this.getAttribute("color"));
    if (colorVariant.includes(this.getAttribute("variant"))) {
        rippleElement.classList.add(`bg-[${colorHex}]/30`);
    } else {
        rippleElement.classList.add("bg-white/30");
    }

    this.appendChild(rippleElement);

    rippleElement.offsetWidth;

    const rect = this.getBoundingClientRect();
    const rippleX = clientX - rect.left - (rippleElement.offsetWidth / 2);
    const rippleY = clientY - rect.top - (rippleElement.offsetHeight / 2);
    rippleElement.style.left = `${rippleX}px`;
    rippleElement.style.top = `${rippleY}px`;

    setTimeout(() => rippleElement.remove(), 600);
}

const boundButtons = new WeakSet();

function bindRipples() {
    const rippleButtons = document.querySelectorAll('.ripple-button');
    rippleButtons.forEach(button => {
        if (!boundButtons.has(button)) {
            button.addEventListener('click', rippleBtn);
            boundButtons.add(button);
        }
    });
}

setInterval(bindRipples, 500);

