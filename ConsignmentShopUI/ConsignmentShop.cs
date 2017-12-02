using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> cartitemslist = new List<Item>();
        BindingSource itemsbind = new BindingSource();
        BindingSource cartbinding = new BindingSource();
        BindingSource Vendorbinding = new BindingSource();
        private decimal storeprofit = 0; 


        public ConsignmentShop()
        {
            InitializeComponent();
            populatevendors();

            itemsbind.DataSource = store.items.Where(x => x.sold == false).ToList();
            itemsListBox.DataSource = itemsbind;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartbinding.DataSource = cartitemslist;
            purchaseditem.DataSource = cartbinding;

            purchaseditem.DisplayMember = "Display";
            purchaseditem.ValueMember = "Display";

            Vendorbinding.DataSource = store.vendors;
            vendorlistbox.DataSource = Vendorbinding;

            vendorlistbox.DisplayMember = "Display";
            vendorlistbox.ValueMember = "Display";
        }


        private void populatevendors()
        {
            
            store.vendors.Add(new Vendor { FirstName = "varun", LastName = "lanke" });
            store.vendors.Add(new Vendor { FirstName = "gowtham", LastName = "medikonda" });
            store.vendors.Add(new Vendor { FirstName = "jagadeeshreddy", LastName = "dornala"});
            store.vendors.Add(new Vendor { FirstName = "manoj", LastName = "jakkapu" });

            store.items.Add(new Item { title = "box", Description = "plastic", owner = store.vendors[0], price = 4.5M });
            store.items.Add(new Item { title = "pen", Description = "inkpen", owner = store.vendors[0], price = 4.8M });
            store.items.Add(new Item { title = "eraser", Description = "stationary", owner = store.vendors[1], price = 1.9M });
            store.items.Add(new Item { title = "tires", Description = "bike", owner = store.vendors[2], price = 12.8M });
            store.items.Add(new Item { title = "car", Description = "toy", owner = store.vendors[2], price = 9.99M });
            store.items.Add(new Item { title = "sniker", Description = "candy", owner = store.vendors[3], price = 2.99M });
            store.items.Add(new Item { title = "visual basics c#", Description = "book", owner = store.vendors[3], price = 29.99M });
            store.items.Add(new Item { title = "cricket ball", Description = "hardtennis", owner = store.vendors[3], price = 6.99M });
            store.items.Add(new Item { title = "bud light", Description = "beer", owner = store.vendors[1], price = 8.49M });

            store.Storename = "FRIENDS STORE ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item selecteditem = (Item)itemsListBox.SelectedItem;
            //MessageBox.Show(selecteditem.title);
            cartitemslist.Add(selecteditem);
            cartbinding.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Item item in cartitemslist)
            {
                item.sold = true;
                item.owner.paymentdue += (decimal)item.owner.Commission * item.price;
                storeprofit += (1-(decimal)item.owner.Commission) * item.price;
            }

            cartitemslist.Clear();
            itemsbind.DataSource = store.items.Where(x => x.sold == false).ToList();
            storeprofitvalue.Text = string.Format("${0}", storeprofit);
            cartbinding.ResetBindings(false);

            itemsbind.ResetBindings(false);
            Vendorbinding.ResetBindings(false);
        }
    }
}
