#pragma checksum "/Users/akshitalathar/Desktop/DataPiratesTeam/DataPiratesTeam/Pages/Congo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3587cca75c0b1df96a447b6efea685f7d0e548d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DataPiratesTeam.Pages.Pages_Congo), @"mvc.1.0.razor-page", @"/Pages/Congo.cshtml")]
namespace DataPiratesTeam.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/akshitalathar/Desktop/DataPiratesTeam/DataPiratesTeam/Pages/_ViewImports.cshtml"
using DataPiratesTeam;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3587cca75c0b1df96a447b6efea685f7d0e548d1", @"/Pages/Congo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f43943229469121fb8cc6db4db02424ab98e9629", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Congo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/akshitalathar/Desktop/DataPiratesTeam/DataPiratesTeam/Pages/Congo.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <style>
        body {
  font-family: 'Roboto';
  margin: 0;
  padding: 0;
}


.container {
  width: 100vw;
  height: 100vh;
  background: #ffffff;
  border: 1px solid white;
  display: fixed;
  top: 0px;
}

.confetti-container {
  perspective: 700px;
  position: absolute;
  overflow: hidden;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
}

.confetti {
  position: absolute;
  z-index: 1;
  top: -10px;
  border-radius: 0%;
}
.confetti--animation-slow {
  animation: confetti-slow 2.25s linear 1 forwards;
}
.confetti--animation-medium {
  animation: confetti-medium 1.75s linear 1 forwards;
}
.confetti--animation-fast {
  animation: confetti-fast 1.25s linear 1 forwards;
}

/* Checkmark */
.checkmark-circle {
  width: 150px;
  height: 150px;
  position: relative;
  display: inline-block;
  vertical-align: top;
  margin-left: auto;
  margin-right: auto;
}

.checkmark-circle .background {
  width: 150px;
  height: 150px;
  border-radius: 50%;
  background: #00C09D;
  position: absolute;
}

.checkmark-cir");
            WriteLiteral(@"cle .checkmark {
  border-radius: 5px;
}

.checkmark-circle .checkmark.draw:after {
  -webkit-animation-delay: 100ms;
  -moz-animation-delay: 100ms;
  animation-delay: 100ms;
  -webkit-animation-duration: 3s;
  -moz-animation-duration: 3s;
  animation-duration: 3s;
  -webkit-animation-timing-function: ease;
  -moz-animation-timing-function: ease;
  animation-timing-function: ease;
  -webkit-animation-name: checkmark;
  -moz-animation-name: checkmark;
  animation-name: checkmark;
  -webkit-transform: scaleX(-1) rotate(135deg);
  -moz-transform: scaleX(-1) rotate(135deg);
  -ms-transform: scaleX(-1) rotate(135deg);
  -o-transform: scaleX(-1) rotate(135deg);
  transform: scaleX(-1) rotate(135deg);
  -webkit-animation-fill-mode: forwards;
  -moz-animation-fill-mode: forwards;
  animation-fill-mode: forwards;
}

.checkmark-circle .checkmark:after {
  opacity: 1;
  height: 75px;
  width: 37.5px;
  -webkit-transform-origin: left top;
  -moz-transform-origin: left top;
  -ms-transform-origin: left top;
  -o-transform");
            WriteLiteral(@"-origin: left top;
  transform-origin: left top;
  border-right: 15px solid white;
  border-top: 15px solid white;
  border-radius: 2.5px !important;
  content: '';
  left: 25px;
  top: 75px;
  position: absolute;
}

-webkit-keyframes checkmark {
  0% {
    height: 0;
    width: 0;
    opacity: 1;
  }
  20% {
    height: 0;
    width: 37.5px;
    opacity: 1;
  }
  40% {
    height: 75px;
    width: 37.5px;
    opacity: 1;
  }
  100% {
    height: 75px;
    width: 37.5px;
    opacity: 1;
  }
}
-moz-keyframes checkmark {
  0% {
    height: 0;
    width: 0;
    opacity: 1;
  }
  20% {
    height: 0;
    width: 37.5px;
    opacity: 1;
  }
  40% {
    height: 75px;
    width: 37.5px;
    opacity: 1;
  }
  100% {
    height: 75px;
    width: 37.5px;
    opacity: 1;
  }
}

.submit-btn {
  height: 45px;
  width: 200px;
  font-size: 15px;
  background-color: #00c09d;
  border: 1px solid #00ab8c;
  color: #fff;
  border-radius: 5px;
  box-shadow: 0 2px 4px 0 rgba(87, 71, 81, 0.2);
  cursor: pointer;
  transition: all 2");
            WriteLiteral(@"s ease-out;
  transition: all .2s ease-out;
}

.submit-btn:hover {
  background-color: #2ca893;
  transition: all .2s ease-out;
}


    </style>
<div class=""js-container container"" style=""top:0px !important;""></div>

<div style=""text-align:center;margin-top:30px;position:  fixed;width:100%;height:100%;top:0px;left:0px;"">
    <div class=""checkmark-circle"">
        <div class=""background""></div>
        <div class=""checkmark draw""></div>
    </div>
    <h1>Congratulations!</h1>
    <p>You are all set. Well done!</p>
    <button class=""submit-btn"" type=""submit"" onclick=""alert('🥺🥺🥺🥺🥺\n Oh no you didn\'t!!!!!!!');"">Continue</button>
</div>
    <script>
        const Confettiful = function (el) {
            this.el = el;
            this.containerEl = null;

            this.confettiFrequency = 3;
            this.confettiColors = [""#EF2964"", ""#00C09D"", ""#2D87B0"", ""#48485E"", ""#EFFF1D""];
            this.confettiAnimations = [""slow"", ""medium"", ""fast""];

            this._setupElements();
            this._rend");
            WriteLiteral(@"erConfetti();
        };

        Confettiful.prototype._setupElements = function () {
            const containerEl = document.createElement(""div"");
            const elPosition = this.el.style.position;

            if (elPosition !== ""relative"" || elPosition !== ""absolute"") {
                this.el.style.position = ""relative"";
            }

            containerEl.classList.add(""confetti-container"");

            this.el.appendChild(containerEl);

            this.containerEl = containerEl;
        };

        Confettiful.prototype._renderConfetti = function () {
            this.confettiInterval = setInterval(() => {
                const confettiEl = document.createElement(""div"");
                const confettiSize = Math.floor(Math.random() * 3) + 7 + ""px"";
                const confettiBackground = this.confettiColors[
                    Math.floor(Math.random() * this.confettiColors.length)];

                const confettiLeft = Math.floor(Math.random() * this.el.offsetWidth) + ""px"";
             ");
            WriteLiteral(@"   const confettiAnimation = this.confettiAnimations[
                    Math.floor(Math.random() * this.confettiAnimations.length)];


                confettiEl.classList.add(
                    ""confetti"",
                    ""confetti--animation-"" + confettiAnimation);

                confettiEl.style.left = confettiLeft;
                confettiEl.style.width = confettiSize;
                confettiEl.style.height = confettiSize;
                confettiEl.style.backgroundColor = confettiBackground;

                confettiEl.removeTimeout = setTimeout(function () {
                    confettiEl.parentNode.removeChild(confettiEl);
                }, 3000);

                this.containerEl.appendChild(confettiEl);
            }, 25);
        };

        window.confettiful = new Confettiful(document.querySelector("".js-container""));
    </script>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CongoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CongoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CongoModel>)PageContext?.ViewData;
        public CongoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
