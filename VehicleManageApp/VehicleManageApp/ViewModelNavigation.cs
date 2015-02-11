using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManageApp.ViewModels;
using Xamarin.Forms;

namespace VehicleManageApp
{
    public class ViewModelNavigation : INavigation
    {
        public Page implementor { get; set; }

        public ViewModelNavigation(Page implementor)
        {
            this.implementor = implementor;
        }

        public void Push(Page page)
        {
            implementor.Navigation.PushAsync(page);
        }

        public void Push<TViewModel>()
            where TViewModel : BaseViewModel
        {
            Push(ViewFactory.CreatePage<TViewModel>());
        }

        public void Pop()
        {
            implementor.Navigation.PopAsync();
        }

        public void PopToRoot()
        {
            implementor.Navigation.PopToRootAsync();
        }

        public void PushModal(Page page)
        {
            implementor.Navigation.PushModalAsync(page);
        }

        public void PushModal<TViewModel>()
            where TViewModel : BaseViewModel
        {
            PushModal(ViewFactory.CreatePage<TViewModel>());
        }

        public void PopModal()
        {
            var modalParent = implementor;
            while (modalParent.Parent as Page != null)
                modalParent = (Page)modalParent.Parent;
            implementor.Navigation.PopModalAsync();
        }

        public void RemovePage(Page page)
        {
            throw new NotImplementedException();
        }

        public void InsertPageBefore(Page page, Page before)
        {
            throw new NotImplementedException();
        }

        public Task PushAsync(Page page)
        {
            return implementor.Navigation.PushAsync(page);
            //throw new NotImplementedException();
        }

        public Task<Page> PopAsync()
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page)
        {
            return implementor.Navigation.PushModalAsync(page);
            //throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync()
        {
            throw new NotImplementedException();
        }

        public Task PushAsync(Page page, bool animated)
        {
            return implementor.Navigation.PushAsync(page);
        }

        public Task<Page> PopAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Page> NavigationStack
        {
            get { throw new NotImplementedException(); }
        }

        public IReadOnlyList<Page> ModalStack
        {
            get { throw new NotImplementedException(); }
        }

        public Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            //return implementor.DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            return implementor.DisplayAlert(title, message, accept, cancel);
        }

        public Task DisplayAlert(string title, string message, string cancel)
        {
            return implementor.DisplayAlert(title, message, cancel);
        }
    }
}
