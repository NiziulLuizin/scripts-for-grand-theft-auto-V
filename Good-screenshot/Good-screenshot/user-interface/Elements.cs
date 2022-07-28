using Good_screenshot.user_interface.managers;
using GTA.UI;
using System.Drawing;
using Good_screenshot.user_interface.creators.resources.structs;
namespace Good_screenshot.user_interface
{
    internal sealed class Elements
    {
        private readonly TextElement _textElement;

        private readonly CustomSprite _customSprite;

        private readonly ContainerElement _containerElement;


        public Elements(CustomSprite customSprite, ContainerElement containerElement, TextElement textElement)
        {
            var containerManager
                = new ContainerElementManager();

            containerManager
                .ReturnAnContainerElementWithThis(
                    new StContainerElementConfiguration() 
                    { 
                        Color 
                        = Color.Black, 
                        
                        Position 
                        = new Point(), 
                        
                        Size 
                        = new Size() 
                    });

            _textElement 
                = textElement;
            
            _customSprite 
                = customSprite;

            _containerElement 
                = containerElement;
        }
        
        internal void ScaledDraw(string textElementCaption)
        {
            _containerElement
                .ScaledDraw();

            _textElement
                .Caption 
                 = textElementCaption;

            _textElement
                .ScaledDraw();

            _customSprite
                .ScaledDraw();
        }
    }
}