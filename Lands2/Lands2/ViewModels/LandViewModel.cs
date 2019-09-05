using System;
using System.Collections.Generic;
using System.Text;

namespace Lands2.ViewModels
{
    using Models;

    public class LandViewModel
    {
        #region Properties
        public Land Land
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public LandViewModel(Land land)
        {
            this.Land = land;
        } 
        #endregion
    }
}
