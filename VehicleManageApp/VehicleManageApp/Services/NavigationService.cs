﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VehicleManageApp.Services
{
    public class NavigationService : INavigationService
    {
        public INavigation Navi { get; internal set; }
        public Page myPage { get; set; }

        public Task<Page> PopAsync()
        {
            return Navi.PopAsync();
        }

        public Task<Page> PopModalAsync()
        {
            return Navi.PopModalAsync();
        }

        public Task PushAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
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

        public Task PopToRootAsync()
        {
            return Navi.PopToRootAsync();
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
            return Navi.PushAsync(page);
        }

        public Task PushModalAsync(Page page)
        {
            return Navi.PushModalAsync(page);
        }

        public Task<bool> DisplayAlert(string title, string message, string accept, string cancel = null)
        {
            return myPage.DisplayAlert(title, message, accept, cancel);
        }
    }
}
