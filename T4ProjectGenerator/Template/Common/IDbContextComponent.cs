﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 12.0.0.0
//  
//     对此文件的更改可能会导致不正确的行为。此外，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace T4ProjectGenerator
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\zy\T4\T4ProjectGenerator\T4ProjectGenerator\Template\Common\IDbContextComponent.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class IDbContextComponent : Base
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System.Data;\r\n\r\nnamespace ");
            
            #line 8 "E:\zy\T4\T4ProjectGenerator\T4ProjectGenerator\Template\Common\IDbContextComponent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Config.CommonNamespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public interface IDbContextComponent\r\n    {\r\n        IDbConnection Conne" +
                    "ction { get; }\r\n        IDbTransaction Transaction { get; set; }\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
