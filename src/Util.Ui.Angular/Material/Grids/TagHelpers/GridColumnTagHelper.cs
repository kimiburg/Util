﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Configs;
using Util.Ui.Material.Grids.Renders;
using Util.Ui.Renders;
using Util.Ui.TagHelpers;

namespace Util.Ui.Material.Grids.TagHelpers {
    /// <summary>
    /// 栅格列
    /// </summary>
    [HtmlTargetElement( "util-grid-column" )]
    public class GridColumnTagHelper : TagHelperBase {
        /// <summary>
        /// 合并列
        /// </summary>
        public int Colspan { get; set; }
        /// <summary>
        /// 左边占位合并列
        /// </summary>
        public int BeforeColspan { get; set; }
        /// <summary>
        /// 右边占位合并列
        /// </summary>
        public int AfterColspan { get; set; }
        /// <summary>
        /// 合并行
        /// </summary>
        public int Rowspan { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new GridColumnRender( new Config( context ) );
        }
    }
}