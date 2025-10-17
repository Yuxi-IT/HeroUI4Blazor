using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.HeroUI.Models
{
    public class ButtonItem
    {
        public RenderFragment? Content { get; set; } // 按钮文本/内容
        public EventCallback OnClick { get; set; }   // 点击事件
        public EventCallback OnLongPress { get; set; } // 长按事件
        public string? ClassName { get; set; }       // 额外样式
    }
}
