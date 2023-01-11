using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            // var context = new ShopContext();
            // if (context.Database.GetPendingMigrations().Count() == 0)
            // {
            //     if (context.Products.Count() == 0)
            //     {
            //         context.Products.AddRange(AddProducts);
            //     }

            //     if (context.Categories.Count() == 0)
            //     {
            //         context.Categories.AddRange(AddCategory);
            //         context.AddRange(AddProductCategory);
            //     }
            // }

            // if (context.Arrangement.Count() == 0)
            // {
            //     context.Arrangement.Add(new Arrangement() {Content = 4} );
            // }

            // if (context.Sliders.Count() == 0)
            // {
            //     context.Sliders.Add(new Slider() {ImageUrl="slider1.png", Active=true, Order=1});
            //     context.Sliders.Add(new Slider() {ImageUrl="slider2.png", Active=false, Order=2});
            //     context.Sliders.Add(new Slider() {ImageUrl="slider3.png", Active=false, Order=3});
            //     context.Sliders.Add(new Slider() {ImageUrl="slider4.jpg", Active=false, Order=4});               
            // }
            
            // context.SaveChanges();
        }

        private static Product[] AddProducts = {
            // Phone
            new Product() {ProductId=1,Name="Apple iPhone Xr",Url="apple-iphone-xr",Price=8923,Rating=5,Description="<b>6.1 İnç</b> Ekran boyutu, <b>64 GB</b> Dahili depolama, <b>3GB</b> Ram, <b>12 MP</b> Kamera çözünürlüğü, <b>2942 mAh</b> Batarya kapasitesine sahip bir <b>Apple</b> telefon ürünüdür.",Stock=4, ImageUrl="1.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=2,Name="iPhone 13 Pro Max",Url="iphone-13-pro-max",Price=24499,Rating=5,Description="<b>6.7 İnç</b> Ekran boyutu, <b>128 GB</b> Dahili depolama, <b>6 GB </b> Ram, <b>12 MP</b> Kamera çözünürlüğü, <b>4352 mAh</b> Batarya kapasitesine sahip bir <b>Apple</b> telefon ürünüdür.",Stock=3,ImageUrl="2.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=3,Name="Poco X3 GT",Url="poxo-x3-gt",Price=4749,Rating=4,Description="<b>6.6 İnç</b> Ekran boyutu, <b>128 GB</b> Dahili depolama, <b>8 GB</b> Ram, <b>64 MP</b> Kamera çözünürlüğü, <b>5000 mAh</b> Batarya kapasitesine sahip bir <b>Xiaomi</b> telefon ürünüdür.",ImageUrl="3.jpg",Stock=7,IsHome=false ,IsApproved=true},
            new Product() {ProductId=4,Name="Samsung Galaxy S20 Fe",Url="samsung-galaxy-s20",Price=6785,Rating=4.5,Description="<b>6.5 İnç</b> Ekran boyutu,<b>128 GB</b> Dahili depolama, <b>6GB Ram</b>, <b>12 MP</b> Kamera çözünürlüğü, <b>4500 mAh</b> Batarya kapasitesine sahip bir <b>Samsung</b> telefon ürünüdür.",Stock=4,ImageUrl="4.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=5,Name="Samsung Galaxy A32",Url="samsung-galaxy-s32",Price=3921,Rating=4,Description="<b>6.4 İnç</b> Ekran boyutu, <b>128 GB</b> Dahili depolama, <b>6 GB</b> Ram, <b>64 MP</b> Kamera çözünürlüğü, <b>5000 mAh</b> Batarya kapasitesine sahip bir <b>Samsung</b> telefon ürünüdür.",Stock=8,ImageUrl="5.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=6,Name="iPhone 12 Pro Max",Url="iphone-12-pro-max",Price=20579,Rating=5,Description="<b>6.7 İnç</b> Ekran boyutu, <b>128 GB</b> Dahili depolama, <b>6 GB</b> Ram, <b>12 MP</b> Kamera çözünürlüğü, <b>3687 mAh</b> Batarya kapasitesine sahip bir <b>Apple</b> telefon ürünüdür.",Stock=4,ImageUrl="6.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=7,Name="Oppo Reno 5 Lite",Url="oppo-reno-5-lite",Price=4399,Rating=3.5,Description="<b>6.4 İnç</b> Ekran boyutu, <b>128 GB</b> Dahili depolama, <b>8 GB</b> Ram, <b>48 MP</b> Kamera çözünürlüğü, <b>4310 mAh</b> Batarya kapasitesine sahip bir <b>Oppo</b> telefon ürünüdür.",Stock=10,ImageUrl="7.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=8,Name="General Mobile Gm21 Pro",Url="general-mobile-gm21-pro",Price=3233,Rating=3,Description="<b>6.6 İnç</b> Ekran boyutu, <b>128 GB</b> Dahili depolama, <b>6 GB</b> Ram, <b>48 MP</b> Kamera çözünürlüğü, <b>5000 mAh</b> Batarya kapasitesine sahip bir <b>General Mobile</b> telefon ürünüdür.",Stock=10,ImageUrl="8.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=9,Name="Xiaomi Redmi 9",Url="xiaomi-redmi-9",Price=2950,Rating=4.5,Description="<b>6.5 İnç</b> Ekran boyutu, <b>32 GB</b> Dahili depolama, <b>3 GB</b> Ram, <b>13 MP</b> Kamera çözünürlüğü, <b>5020 mAh</b> Batarya kapasitesine sahip bir <b>Xiaomi</b> telefon ürünüdür.",Stock=5,ImageUrl="9.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=10,Name="Oppo A74",Url="oppo-a74",Price=3299,Rating=4.5,Description="<b>6.4 İnç</b> Ekran boyutu, <b>128 GB</b> Dahili depolama, <b>4 GB</b> Ram, <b>48 MP</b> Kamera çözünürlüğü, <b>5000 mAh</b> Batarya kapasitesine sahip bir <b>Oppo</b> telefon ürünüdür.",Stock=6,ImageUrl="10.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=11,Name="Xiaomi Mi 11T",Url="xiaomi-mi-11t",Price=9799,Rating=4.5,Description="<b>6.6 İnç</b> Ekran boyutu, <b>256 GB</b> Dahili depolama, <b>8 GB</b> Ram, <b>108 MP</b> Kamera çözünürlüğü, <b>5000 mAh</b> Batarya kapasitesine sahip bir <b>Xiaomi</b> telefon ürünüdür.",Stock=5,ImageUrl="11.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=12,Name="Oppo Realme 8 Pro",Url="oppo-realme-8-pro",Price=3299,Rating=3.5,Description="<b>6.4 İnç</b> Ekran boyutu, <b>128 GB</b> Dahili depolama, <b>4 GB</b> Ram, <b>48 MP</b> Kamera çözünürlüğü, <b>5000 mAh</b> Batarya kapasitesine sahip bir <b>Oppo</b> telefon ürünüdür.",Stock=10,ImageUrl="12.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=13,Name="Samsung Galaxy S21 Plus",Url="samsung-galaxy-s21-plus",Price=13885,Rating=5,Description="<b>6.7 İnç</b> Ekran boyutu, <b>128 GB</b> Dahili depolama, <b>8 GB</b> Ram, <b>12 MP</b> Kamera çözünürlüğü, <b>4800 mAh</b> Batarya kapasitesine sahip bir <b>Samsung</b> telefon ürünüdür.",Stock=8,ImageUrl="31.jpg",IsHome=true ,IsApproved=true},
            // Laptop
            new Product() {ProductId=14,Name="Huawei Matebook D 16",Url="huawei-matebook-d-16",Price=10499,Rating=5,Description="<b>16.1 İnç</b> Ekran boyutu, <b>1920x1080 Piksel</b> Ekran çözünürlüğü, <b>Amd Ryzen 5 4600H</b> İşlemcisi <b>16 GB</b> Ram, <b>512 GB SSD</b> Depolamaya sahip sahip bir <b>Huawei</b> laptop ürünüdür.",Stock=7,ImageUrl="13.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=15,Name="Huawei Matebook 14",Url="huawei-matebook-14",Price=9499,Rating=4,Description="<b>14 İnç</b> Ekran boyutu, <b>2160x1440 Piksel</b> Ekran çözünürlüğü, <b>Amd Ryzen 5 4600 H</b> İşlemcisi <b>8 GB</b> Ram, <b>256 GB SSD</b> Depolamaya sahip sahip bir <b>Huawei</b> laptop ürünüdür.",Stock=10,ImageUrl="14.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=16,Name="Huawei Matebook 15 Core",Url="huawei-matebook-15-core",Price=7008,Rating=4.5,Description="<b>15.6 İnç</b> Ekran boyutu, <b>1920x1080 Piksel</b> Ekran çözünürlüğü, <b>İntel Core i5</b> İşlemcisi <b>16 GB</b> Ram, <b>512 GB SSD</b> Depolamaya sahip sahip bir <b>Huawei</b> laptop ürünüdür.",Stock=9,ImageUrl="15.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=17,Name="Macbook Pro MK183TU/A M1 Pro",Url="macbook-pro-m1-pro",Price=16423,Rating=4,Description="<b>16.2 İnç</b> Ekran boyutu, <b>3456x2234 Piksel</b> Ekran çözünürlüğü, <b>Apple M1 Pro</b> İşlemcisi <b>16 GB</b> Ram, <b>512 GB SSD</b> Depolamaya sahip sahip bir <b>Apple</b> laptop ürünüdür.",Stock=7,ImageUrl="16.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=18,Name="Asus Rog Strix G15",Url="asus-rog-strix-g15",Price=27690,Rating=4,Description="<b>15.6 İnç</b> Ekran boyutu, <b>1920x1080 Piksel</b> Ekran çözünürlüğü, <b>İntel Core i7</b> İşlemcisi <b>16 GB</b> Ram, <b>512 GB SSD</b> Depolamaya sahip sahip bir <b>Asus</b> laptop ürünüdür.",Stock=11,ImageUrl="17.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=19,Name="Honor Magic Book X15 Core",Url="honor-magic-book-x15-core",Price=8539,Rating=4,Description="<b>15.6 İnç</b> Ekran boyutu, <b>1920x1080 Piksel</b> Ekran çözünürlüğü, <b>İntel Core i3</b> İşlemcisi <b>8 GB</b> Ram, <b>256 GB SSD</b> Depolamaya sahip sahip bir <b>Honor</b> laptop ürünüdür.",Stock=12,ImageUrl="18.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=20,Name="Huawei Matebook X Pro",Url="huawei-matebook-x-pro",Price=18499,Rating=4.5,Description="<b>13.9 İnç</b> Ekran boyutu, <b>3000x2000 Piksel</b> Ekran çözünürlüğü, <b>İntel Core i7</b> İşlemcisi <b>16 GB</b> Ram, <b>1 TB SSD</b> Depolamaya sahip sahip bir <b>Huawei</b> laptop ürünüdür.",Stock=6,ImageUrl="19.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=21,Name="Monster Abra A5 V16",Url="monster-abra-a5-v16",Price=11299,Rating=5,Description="<b>15.6 İnç</b> Ekran boyutu, <b>1920x1080 Piksel</b> Ekran çözünürlüğü, <b>İntel Core i5</b> İşlemcisi <b>8 GB</b> Ram, <b>256 GB SSD</b> Depolamaya sahip sahip bir <b>Monster</b> laptop ürünüdür.",Stock=4,ImageUrl="20.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=22,Name="Msi GE76 Raider 11UH",Url="msi-ge76-raider-11uh",Price=41282,Rating=5,Description="<b>17.3 İnç</b> Ekran boyutu, <b>2560x1440 Piksel</b> Ekran çözünürlüğü, <b>İntel Core i7</b> İşlemcisi <b>32 GB</b> Ram, <b>1 TB SSD</b> Depolamaya sahip sahip bir <b>Msi</b> laptop ürünüdür.",Stock=5,ImageUrl="21.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=23,Name="Casper Excalibur G911",Url="casper-excalibur-g911",Price=24699,Rating=4.5,Description="<b>16 İnç</b> Ekran boyutu, <b>2560x1440 Piksel</b> Ekran çözünürlüğü, <b>İntel Core i9</b> İşlemcisi <b>32 GB</b> Ram, <b>4 TB SSD</b> Depolamaya sahip sahip bir <b>Casper</b> laptop ürünüdür.",Stock=8,ImageUrl="22.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=24,Name="Msi GP66 Leopard 11UG",Url="msi-gp66-leopard-11ug",Price=35515,Rating=5,Description="<b>15.6 İnç</b> Ekran boyutu, <b>1920x1080 Piksel</b> Ekran çözünürlüğü, <b>İntel Core i7</b> İşlemcisi <b>16 GB</b> Ram, <b>512 GB SSD</b> Depolamaya sahip sahip bir <b>Msi</b> laptop ürünüdür.",Stock=5,ImageUrl="23.jpg",IsHome=true ,IsApproved=true},
            // Desktop Computer
            new Product() {ProductId=25,Name="Thermaltake Level 20 MT",Url="thermaltake-level-20-mt",Price=1444,Rating=5,Description="<b>ATX</b> Anakartlar için, <b>10 Adet</b> Fan kapasitesi, <b>2 Adet</b> Harddisk kapasitesi, <b>6.75 Kg</b> Ağırlığa sahip sahip bir <b>Thermaltake</b> Masaüstü Bilgisayar ürünüdür.",Stock=6,ImageUrl="24.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=26,Name="Msi Mag Forge Kasa",Url="msi-mag-forge-100mm",Price=927,Rating=4.5,Description="<b>ATX</b> Anakartlar için, <b>6 Adet</b> Fan kapasitesi, <b>3 Adet</b> Harddisk kapasitesi, <b>5.6 Kg</b> Ağırlığa sahip sahip bir <b></b> Masaüstü Bilgisayar ürünüdür.",Stock=9,ImageUrl="25.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=27,Name="Power Boost VK-T01B",Url="power-boost-vk-t01b",Price=1349,Rating=4.5,Description="<b>ATX</b> Anakartlar için, <b>10 Adet</b> Fan kapasitesi, <b>2 Adet</b> Harddisk kapasitesi, <b>6.75 Kg</b> Ağırlığa sahip sahip bir <b>Thermaltake</b> Masaüstü Bilgisayar ürünüdür.",Stock=12,ImageUrl="26.jpg",IsHome=false ,IsApproved=true},
            new Product() {ProductId=28,Name="Gameforce GF-8307 Glass 4X120M",Url="gameforce-gf-8307-glass-4x120m",Price=12000,Rating=5,Description="<b>ATX</b> Anakartlar için, <b>6 Adet</b> Fan kapasitesi, <b>1 HDD + 1 SSD</b> kapasitesi, <b>4.7 Kg</b> Ağırlığa sahip sahip bir <b>Gameforce</b> Masaüstü Bilgisayar ürünüdür.",Stock=9,ImageUrl="27.jpg",IsHome=true ,IsApproved=true},
            // Tablet
            new Product() {ProductId=29,Name="Samsung Galaxy Tab S6 Lite",Url="samsung-galaxy-tab-s6-lite",Price=3795,Rating=5,Description="<b>10.4 İnç</b> Ekran boyutu, <b>64 GB</b> Dahili depolama, <b>4 GB</b> Ram, <b>8 MP</b> Kamera çözünürlüğü, <b>7040 mAh</b> Batarya kapasitesine sahip bir <b>Samsung</b> tablet ürünüdür.",Stock=5,ImageUrl="28.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=30,Name="Lenovo Tab m10 Mtk Helio",Url="lenovo-tab-m10-mtk-helio",Price=2099,Rating=4.5,Description="<b>10.1 İnç</b> Ekran boyutu, <b>64 GB</b> Dahili depolama, <b>4 GB</b> Ram, <b>8 MP</b> Kamera çözünürlüğü, <b>5000 mAh</b> Batarya kapasitesine sahip bir <b>Lenovo</b> tablet ürünüdür.",Stock=7,ImageUrl="29.jpg",IsHome=true ,IsApproved=true},
            new Product() {ProductId=31,Name="Samsung Galaxy Tab A7 Lite",Url="samsung-galaxy-tab-a7-lite",Price=1427,Rating=5,Description="<b>8.7 İnç</b> Ekran boyutu, <b>32 GB</b> Dahili depolama, <b>3 GB</b> Ram, <b>8 GB</b> Kamera çözünürlüğü, <b>5100 mAh</b> Batarya kapasitesine sahip bir <b>Samsung</b> tablet ürünüdür.",Stock=5,ImageUrl="30.jpg",IsHome=true ,IsApproved=true},
        };

        private static Category[] AddCategory = {
            new Category() {CategoryId=1,Name="Telefon",Url="telefon"},            
            new Category() {CategoryId=2,Name="Laptop",Url="laptop"},
            new Category() {CategoryId=3,Name="Masaüstü Bilgisayar",Url="bilgisayar"},
            new Category() {CategoryId=4,Name="Tablet",Url="tablet"},
        };

        private static ProductCategory[] AddProductCategory = {
            // PHONE
            new ProductCategory() {Product=AddProducts[0],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[1],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[2],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[3],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[4],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[5],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[6],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[7],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[8],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[9],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[10],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[11],Category=AddCategory[0]},
            new ProductCategory() {Product=AddProducts[12],Category=AddCategory[0]},
            // LAPTOP
            new ProductCategory() {Product=AddProducts[13],Category=AddCategory[1]},
            new ProductCategory() {Product=AddProducts[14],Category=AddCategory[1]},
            new ProductCategory() {Product=AddProducts[15],Category=AddCategory[1]},
            new ProductCategory() {Product=AddProducts[16],Category=AddCategory[1]},
            new ProductCategory() {Product=AddProducts[17],Category=AddCategory[1]},
            new ProductCategory() {Product=AddProducts[18],Category=AddCategory[1]},
            new ProductCategory() {Product=AddProducts[19],Category=AddCategory[1]},
            new ProductCategory() {Product=AddProducts[20],Category=AddCategory[1]},
            new ProductCategory() {Product=AddProducts[21],Category=AddCategory[1]},
            new ProductCategory() {Product=AddProducts[22],Category=AddCategory[1]},
            new ProductCategory() {Product=AddProducts[23],Category=AddCategory[1]},
            // Desktop Computer
            new ProductCategory() {Product=AddProducts[24],Category=AddCategory[2]},
            new ProductCategory() {Product=AddProducts[25],Category=AddCategory[2]},
            new ProductCategory() {Product=AddProducts[26],Category=AddCategory[2]},
            new ProductCategory() {Product=AddProducts[27],Category=AddCategory[2]},
            // Tablet
            new ProductCategory() {Product=AddProducts[28],Category=AddCategory[3]},
            new ProductCategory() {Product=AddProducts[29],Category=AddCategory[3]},
            new ProductCategory() {Product=AddProducts[30],Category=AddCategory[3]},
        };
    }
}