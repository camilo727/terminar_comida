using System;
using System.Collections.Generic;
using System.Text;
using terminar_comida.ViewModel;

namespace terminar_comida.InfraEstructure
{
    class InstaceLocator
    {
        public MainViewModelClass main {get ;set;}
        public InstaceLocator()
        {
            this.main = new MainViewModelClass();
        }

    }
}
