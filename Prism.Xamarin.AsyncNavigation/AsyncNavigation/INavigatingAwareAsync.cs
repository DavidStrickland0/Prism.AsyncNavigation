using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;

namespace Prism.Xamarin.AsyncNavigation
{
    interface INavigatingAwareAsync
    {
        /// <summary>
        /// Called before the implementor has been navigated to.
        /// </summary>
        /// <param name="parameters">The navigation parameters.</param>
        /// <remarks>Not called when using device hardware or software back buttons</remarks>
        Task OnNavigatingToAsync(INavigationParameters parameters);
    }
}
