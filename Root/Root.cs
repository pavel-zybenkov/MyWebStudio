using System.Threading;
namespace MyWebStudio.Root {

    public partial class Root : PageBase {
        public override string Title => "MyWebStudio - Home page";

        public override Inlines? Description => "Home page of StaticSharp sample project";

        public override Blocks Content => new() {
            new LinearLayout {
                Vertical = false,
                SecondaryGravity = 0,
                Children = {
                    new Image("MyWebStudioLogo.png"){
                    Height = 300
                    },
                    new LinearLayout{
                        Children = {
                            new Paragraph("MY web studio") {
                                FontSize = 32,
                                ForegroundColor = Color.GreenYellow,
                            },
                            "We create the best web sites in the world!",
                        }    
                    },
                }
            },
            // new Image("MyWebStudioLogo.png"){
            //     Width = 500
            // },
            // new Paragraph("MY web studio") {
            //     FontSize = 32,
            //     ForegroundColor = Color.GreenYellow,
            // },
            new LinearLayout {
                Vertical = false,
                SecondaryGravity = 0,
                Children = {
                    new SvgIconBlock(SvgIcons.MaterialDesignIcons.Web){
                        Height = 200,
                    },
                    string.Concat(Enumerable.Repeat("text ", 50))
                }
            },
            new LinearLayout {
                Vertical = false,
                SecondaryGravity = 0,
                Children = {
                    string.Concat(Enumerable.Repeat("text ", 50)),
                    new SvgIconBlock(SvgIcons.MaterialDesignIcons.Web) {
                        Height = 200
                    },
                }
            },
            new LinearLayout {
                Vertical = false,
                SecondaryGravity = 0,
                Children = {
                    new SvgIconBlock(SvgIcons.MaterialDesignIcons.Web){
                        Height = 200,
                    },
                    string.Concat(Enumerable.Repeat("text ", 50))
                }
            },
            new LinearLayout {
                Vertical = false,
                SecondaryGravity = 0,
                Children = {
                    string.Concat(Enumerable.Repeat("text ", 50)),
                    new SvgIconBlock(SvgIcons.MaterialDesignIcons.Web) {
                        Height = 200
                    },
                }
            }
        };
        
        protected override void Setup(Context context) {
            BackgroundColor = Color.Gray;
            base.Setup(context);
        }

    }
}
