using GTA.UI;

using System.Collections.Generic;


namespace Good_screenshot.user_interface
{
    internal sealed class Elements
    {
        private readonly IEnumerable<IElement> _elements;


        public Elements(IEnumerable<IElement> elements)
        {
            _elements
                = elements;
        }

        internal void ScaledDraw()
        {
            foreach (var element in _elements)
            {
                element
                    .ScaledDraw();
            }
        }
    }
}