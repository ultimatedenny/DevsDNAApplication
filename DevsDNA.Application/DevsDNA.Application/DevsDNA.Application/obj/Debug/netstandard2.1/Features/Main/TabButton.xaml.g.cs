//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("DevsDNA.Application.Features.Main.TabButton.xaml", "Features/Main/TabButton.xaml", typeof(global::DevsDNA.Application.Features.Main.TabButton))]

namespace DevsDNA.Application.Features.Main {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Features\\Main\\TabButton.xaml")]
    public partial class TabButton : global::Xamarin.Forms.Grid {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.TapGestureRecognizer tapGestureRecognizer;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::DevsDNA.Application.Controls.LabelTypewriter LblText;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(TabButton));
            tapGestureRecognizer = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.TapGestureRecognizer>(this, "tapGestureRecognizer");
            LblText = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::DevsDNA.Application.Controls.LabelTypewriter>(this, "LblText");
        }
    }
}
