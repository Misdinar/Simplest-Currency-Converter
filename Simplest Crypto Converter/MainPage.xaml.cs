using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Simplest_Crypto_Converter
{
    public partial class MainPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(OpenBrowser);
        public ICommand LocalCommand => new Command(ButtonReset);
        public ICommand CalculateCommand => new Command(Calculate);
        private const double BTC = 668408953.70;
        private const double DOGE = 2049.65;
        private const double ETH = 677278.26;
        private const double NXS = 5233.24;
        private const double KMD = 8900.72;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void OpenBrowser(string url)
        {
            Device.OpenUri(new Uri(url));
        }

        void CryptoChanged(object sender, EventArgs args)
        {
            if (RBBitcoin.IsChecked)
            {
                labelCrypto.Text = "Masukkan Jumlah Bitcoin:";
                label.Text = $"1 Bitcoin = Rp668.408.953,70";
            }
            else if (RBEthereum.IsChecked)
            {
                labelCrypto.Text = "Masukkan Jumlah Ethereum:";
                label.Text = $"1 Ethereum = Rp677.184,24";
            }
            else if (RBNexus.IsChecked)
            {
                labelCrypto.Text = "Masukkan Jumlah Nexus:";
                label.Text = $"1 Nexus = Rp{NXS}";
            }
            else if (RBKomodo.IsChecked)
            {
                labelCrypto.Text = "Masukkan Jumlah Komodo:";
                label.Text = $"1 Komodo = Rp{KMD}";
            }
            else if (RBDogecoin.IsChecked)
            {
                labelCrypto.Text = "Masukkan Jumlah Dogecoin:";
                label.Text = $"1 Dogecoin = Rp{DOGE}";
            }


        }

        private void ButtonReset()
        {
            entRupiah.Text = "";
            entCrypto.Text = "";
        }

        private void Calculate()
        {
            
            if (RBBitcoin.IsChecked)
            {
                if(entRupiah.Text=="" && entCrypto.Text != "")
                {
                    entRupiah.Text = Convert.ToString(float.Parse(entCrypto.Text) * BTC);
                }
                else if(entRupiah.Text != "" && entCrypto.Text == "")
                {
                    entCrypto.Text = Convert.ToString(float.Parse(entRupiah.Text)/ BTC);
                }
               
            }
            else if (RBEthereum.IsChecked)
            {
                if (entRupiah.Text == "" && entCrypto.Text != "")
                {
                    entRupiah.Text = Convert.ToString(float.Parse(entCrypto.Text) * ETH);
                }
                else if (entRupiah.Text != "" && entCrypto.Text == "")
                {
                    entCrypto.Text = Convert.ToString(float.Parse(entRupiah.Text) / ETH);
                }
            }
            else if (RBNexus.IsChecked)
            {
                if (entRupiah.Text == "" && entCrypto.Text != "")
                {
                    entRupiah.Text = Convert.ToString(float.Parse(entCrypto.Text) * NXS);
                }
                else if (entRupiah.Text != "" && entCrypto.Text == "")
                {
                    entCrypto.Text = Convert.ToString(float.Parse(entRupiah.Text) / NXS);
                }
            }
            else if (RBKomodo.IsChecked)
            {
                if (entRupiah.Text == "" && entCrypto.Text != "")
                {
                    entRupiah.Text = Convert.ToString(float.Parse(entCrypto.Text) * KMD);
                }
                else if (entRupiah.Text != "" && entCrypto.Text == "")
                {
                    entCrypto.Text = Convert.ToString(float.Parse(entRupiah.Text) / KMD);
                }
            }
            else if (RBDogecoin.IsChecked)
            {
                if (entRupiah.Text == "" && entCrypto.Text != "")
                {
                    entRupiah.Text = Convert.ToString(float.Parse(entCrypto.Text) * DOGE);
                }
                else if (entRupiah.Text != "" && entCrypto.Text == "")
                {
                    entCrypto.Text = Convert.ToString(float.Parse(entRupiah.Text) / DOGE);
                }
            }
        }
    }
}
