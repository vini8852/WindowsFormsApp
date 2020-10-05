using DataLibrary;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysforeShopping
{
    public static class DataUtils
    {
        public static List<ProductCategory> FillProductCategories()
        {
            List<ProductCategory> categoryData = new List<ProductCategory>();
            ProductCategory productCategory = new ProductCategory();
            productCategory.CategoryId = 1;
            productCategory.CategoryName = "Home Essentials";
            productCategory.CategoryDescription = "All home maintenance equipments";
            categoryData.Add(productCategory);

            productCategory = new ProductCategory();
            productCategory.CategoryId = 2;
            productCategory.CategoryName = "Office Supplies";
            productCategory.CategoryDescription = "Office stationery and equipments";
            categoryData.Add(productCategory);

            productCategory = new ProductCategory();
            productCategory.CategoryId = 3;
            productCategory.CategoryName = "Kitchen and Utility";
            productCategory.CategoryDescription = "Kitchen items, cleaning equipments";
            categoryData.Add(productCategory);

            productCategory = new ProductCategory();
            productCategory.CategoryId = 4;
            productCategory.CategoryName = "Sports & Fitness Products";
            productCategory.CategoryDescription = "Indoor and Outdoor Sport Products";
            categoryData.Add(productCategory);

            return categoryData;
        }

        public static List<ProductSubCategory> FillProductSubCategories()
        {
            List<ProductSubCategory> subCategoryData = new List<ProductSubCategory>();
            ProductSubCategory productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 1;
            productSubCategory.SubCategoryId = 1;
            productSubCategory.SubCategoryName = "Cupboards and Storage";
            productSubCategory.SubCategoryDescription = "Storage Cabinets, Racks, Chest of Drawers, etc.,";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 1;
            productSubCategory.SubCategoryId = 2;
            productSubCategory.SubCategoryName = "Cleaning & Maintenance";
            productSubCategory.SubCategoryDescription = "Mops, Brooms, Vaccum leaners, Robots, etc.";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 1;
            productSubCategory.SubCategoryId = 3;
            productSubCategory.SubCategoryName = "Home Decor";
            productSubCategory.SubCategoryDescription = "Home wellness and interior decoration";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 1;
            productSubCategory.SubCategoryId = 4;
            productSubCategory.SubCategoryName = "Furniture";
            productSubCategory.SubCategoryDescription = "Living Room, Chairs, Tables and Desks, Bean Bags, etc";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 2;
            productSubCategory.SubCategoryId = 5;
            productSubCategory.SubCategoryName = "Note Counters & Paper Shredders";
            productSubCategory.SubCategoryDescription = "Note Counters and Paper Shredders etc.,";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 2;
            productSubCategory.SubCategoryId = 6;
            productSubCategory.SubCategoryName = "Laminators & Binders";
            productSubCategory.SubCategoryDescription = "Laminators,Binders etc.,";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 2;
            productSubCategory.SubCategoryId = 7;
            productSubCategory.SubCategoryName = "Labeling & Stamping Machine";
            productSubCategory.SubCategoryDescription = "Labeling,Stamping Machine, etc.,";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 2;
            productSubCategory.SubCategoryId = 8;
            productSubCategory.SubCategoryName = "Computers and other Hardware";
            productSubCategory.SubCategoryDescription = "Computers, Printers,Scanners, etc.,";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 3;
            productSubCategory.SubCategoryId = 9;
            productSubCategory.SubCategoryName = "Juicer, Mixture & Grinder";
            productSubCategory.SubCategoryDescription = "Juicers, Mixtures and Grinders, etc.,";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 3;
            productSubCategory.SubCategoryId = 10;
            productSubCategory.SubCategoryName = "Water Purifiers";
            productSubCategory.SubCategoryDescription = "All types of water purifiers";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 3;
            productSubCategory.SubCategoryId = 11;
            productSubCategory.SubCategoryName = "Food Processors";
            productSubCategory.SubCategoryDescription = "All types of multifunctional food preparing machines ";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 3;
            productSubCategory.SubCategoryId = 12;
            productSubCategory.SubCategoryName = "Kitchen Tools";
            productSubCategory.SubCategoryDescription = "Kitchen tools and other Hardwares used to kitchens";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 4;
            productSubCategory.SubCategoryId = 13;
            productSubCategory.SubCategoryName = "Football";
            productSubCategory.SubCategoryDescription = "All Football Equipments and Gears";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 4;
            productSubCategory.SubCategoryId = 14;
            productSubCategory.SubCategoryName = "Cricket";
            productSubCategory.SubCategoryDescription = "All Cricket Equipments and Gears";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 4;
            productSubCategory.SubCategoryId = 15;
            productSubCategory.SubCategoryName = "BodyBuilding & Fitness ";
            productSubCategory.SubCategoryDescription = "Gym and other Fitness Products";
            subCategoryData.Add(productSubCategory);

            productSubCategory = new ProductSubCategory();
            productSubCategory.CategoryId = 4;
            productSubCategory.SubCategoryId = 16;
            productSubCategory.SubCategoryName = "Running";
            productSubCategory.SubCategoryDescription = "All Equipments and Gadgets required for Running";
            subCategoryData.Add(productSubCategory);

            return subCategoryData;
        }
        public static List<ProductItems> FillProductItems()
        {
            List<ProductItems> listOfProductItems = new List<ProductItems>();
            ProductItems ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 1;
            ProductItems.ProductId = 1;
            ProductItems.Price = 7600.00;
            ProductItems.ProductName = "Noriko Two Door Wardrobe with Two Drawers and Mirror";
            ProductItems.ProductDescription = "Two Door Wardrobe";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 1;
            ProductItems.ProductId = 2;
            ProductItems.Price = 2000.00;
            ProductItems.ProductName = "Almirah Kidsmlx Lkl66";
            ProductItems.ProductDescription = "Plastic Wardrobe Cupboard";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 1;
            ProductItems.ProductId = 3;
            ProductItems.Price = 9345.00;
            ProductItems.ProductName = "Hometown Ibis Multipurpose Cabinet (Wenge)";
            ProductItems.ProductDescription = "Multipurpose Cabinet";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 1;
            ProductItems.ProductId = 4;
            ProductItems.Price = 2000.00;
            ProductItems.ProductName = "Armoire Wardrobe Storage Cabinet";
            ProductItems.ProductDescription = "Wardrobe Storage Cabinet";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 2;
            ProductItems.ProductId = 5;
            ProductItems.Price = 4544.00;
            ProductItems.ProductName = "Remington Hunting Cleaning and Maintenance Kit";
            ProductItems.ProductDescription = "Hunting Cleaning and Maintenance Kit";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 2;
            ProductItems.ProductId = 6;
            ProductItems.Price = 544.00;
            ProductItems.ProductName = "Alix 16 Wood And Laminate Floor Cleaner Polish";
            ProductItems.ProductDescription = "Floor Cleaner Polish";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 2;
            ProductItems.ProductId = 7;
            ProductItems.Price = 999.00;
            ProductItems.ProductName = "Euroclean Xforce Vacuum Cleaner";
            ProductItems.ProductDescription = "Vacuum Cleaner";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 3;
            ProductItems.ProductId = 8;
            ProductItems.Price = 725.00;
            ProductItems.ProductName = "WallTola PVC Vinyl Colorful Decorative Peacock Wall Sticker";
            ProductItems.ProductDescription = "Wall Sticker";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 3;
            ProductItems.ProductId = 9;
            ProductItems.Price = 2990.00;
            ProductItems.ProductName = "DecorNation Red & Black MDF Nesting Square Durable Wall Shelf";
            ProductItems.ProductDescription = "Durable Wall Shelf";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 4;
            ProductItems.ProductId = 10;
            ProductItems.Price = 24990.00;
            ProductItems.ProductName = "Amaani Furniture's Solid Wood Queen Size Bed with Storage ";
            ProductItems.ProductDescription = "Bed with Storage";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 4;
            ProductItems.ProductId = 11;
            ProductItems.Price = 17000.00;
            ProductItems.ProductName = "Oscar Three Seater Sofa in Peacock Blue Colour";
            ProductItems.ProductDescription = "Sofa Sets";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 5;
            ProductItems.ProductId = 12;
            ProductItems.Price = 3290.00;
            ProductItems.ProductName = "Office Bird Note Counting Machine (ob 2020)";
            ProductItems.ProductDescription = "Note Counting Machine";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 5;
            ProductItems.ProductId = 13;
            ProductItems.Price = 4600.00;
            ProductItems.ProductName = "Gadget Hero's Mini Desktop Paper Shredder Machine Manual A5 Size";
            ProductItems.ProductDescription = "Paper Shredder Machine";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 5;
            ProductItems.ProductId = 14;
            ProductItems.Price = 7500.00;
            ProductItems.ProductName = "Namibind Paper Shredder Machine OS-005";
            ProductItems.ProductDescription = "Paper Shredder Machine";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 6;
            ProductItems.ProductId = 15;
            ProductItems.Price = 3700.00;
            ProductItems.ProductName = "Imp A3 Pouch Lamination Machinexl1233025";
            ProductItems.ProductDescription = "Lamination Machine";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 6;
            ProductItems.ProductId = 16;
            ProductItems.Price = 4890.00;
            ProductItems.ProductName = "Oddy Compact 12 inch Lamination Machine - A3-4R LM-A3-4R";
            ProductItems.ProductDescription = "Lamination Machine";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 6;
            ProductItems.ProductId = 17;
            ProductItems.Price = 925.00;
            ProductItems.ProductName = "Namibind Thermal Binding Machines NB-1000";
            ProductItems.ProductDescription = "Thermal Binding Machines";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 7;
            ProductItems.ProductId = 18;
            ProductItems.Price = 2700.00;
            ProductItems.ProductName = "Brother P-Touch PT-D200MA Label Maker";
            ProductItems.ProductDescription = "Label Maker";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 7;
            ProductItems.ProductId = 19;
            ProductItems.Price = 9200.00;
            ProductItems.ProductName = "Accurate Electronics PAX POS Bill and Label Printing Weighing Scale";
            ProductItems.ProductDescription = "Label Printing Machine";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 7;
            ProductItems.ProductId = 20;
            ProductItems.Price = 8700.00;
            ProductItems.ProductName = "Tvs Pt-262 Thermal Printer";
            ProductItems.ProductDescription = "Thermal Label Printer and Stamp Making Machine";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 8;
            ProductItems.ProductId = 21;
            ProductItems.Price = 3000.00;
            ProductItems.ProductName = "Bizinto 41 In 1 Pcs Tool Kit and Screwdriver Set UV_HT_06";
            ProductItems.ProductDescription = "Tool Kit and Screwdriver";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 8;
            ProductItems.ProductId = 22;
            ProductItems.Price = 5700.00;
            ProductItems.ProductName = "Black & Decker - EPC12 - 12V Cordless Drill And Driver (16 Pc. Kit + 2 Batteries)";
            ProductItems.ProductDescription = "Driller Kit and Drivers";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 8;
            ProductItems.ProductId = 23;
            ProductItems.Price = 47000.00;
            ProductItems.ProductName = "ACER Desktop PC COMPUTER CORE i5 PROCESSOR / 8GB RAM /320GB HDD/DELL LED MONITOR";
            ProductItems.ProductDescription = "Desktop And Computers";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 8;
            ProductItems.ProductId = 24;
            ProductItems.Price = 25000.00;
            ProductItems.ProductName = "DELL Desktop Inspiron Aio 3043(Intel PQC N3540/500 GB/ 2GB/ Windows 8.1/ 19.5)";
            ProductItems.ProductDescription = "Desktop And Computers";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 9;
            ProductItems.ProductId = 25;
            ProductItems.Price = 3500.00;
            ProductItems.ProductName = "Philips HL1631 500-Watt Juicer";
            ProductItems.ProductDescription = "Juicer";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 9;
            ProductItems.ProductId = 26;
            ProductItems.Price = 4549.00;
            ProductItems.ProductName = "Cello 850W Mixer Grinder (Model: GNM1100-ULTRA)";
            ProductItems.ProductDescription = "Mixer Grinder";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 9;
            ProductItems.ProductId = 27;
            ProductItems.Price = 14619.00;
            ProductItems.ProductName = "Black and Decker 140W Hand Mixer";
            ProductItems.ProductDescription = "Hand Mixture";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 9;
            ProductItems.ProductId = 28;
            ProductItems.Price = 4619.00;
            ProductItems.ProductName = "Sujata 810W Powermatic Plus Juicer Mixer Grinder";
            ProductItems.ProductDescription = "Juicer Mixer Grinder";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 9;
            ProductItems.ProductId = 29;
            ProductItems.Price = 5209.00;
            ProductItems.ProductName = "Bajaj FX11 Food Processor";
            ProductItems.ProductDescription = "Juicer Mixer Grinder";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 9;
            ProductItems.ProductId = 30;
            ProductItems.Price = 15575.00;
            ProductItems.ProductName = "Black & Decker FX Food Processor 1000 W Juicer Mixer Grinder";
            ProductItems.ProductDescription = "Juicer Mixer Grinder";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 10;
            ProductItems.ProductId = 31;
            ProductItems.Price = 6500.00;
            ProductItems.ProductName = "Kent Ultra Water Purifier";
            ProductItems.ProductDescription = "Water Purifier";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 10;
            ProductItems.ProductId = 32;
            ProductItems.Price = 1445.00;
            ProductItems.ProductName = "Pureit Classic 14 Litres Water Purifier";
            ProductItems.ProductDescription = "Water Purifier";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 11;
            ProductItems.ProductId = 33;
            ProductItems.Price = 5209.00;
            ProductItems.ProductName = "Bajaj FX11 Food Processor";
            ProductItems.ProductDescription = "Food Processor";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 11;
            ProductItems.ProductId = 34;
            ProductItems.Price = 7980.00;
            ProductItems.ProductName = "Morphy Richards Icon DLX 1000-Watt Food Processor";
            ProductItems.ProductDescription = "Food Processor";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 12;
            ProductItems.ProductId = 35;
            ProductItems.Price = 175.00;
            ProductItems.ProductName = "High Quality Wooden Kitchen Tools Set Of 5 Pieces";
            ProductItems.ProductDescription = "Kitchen Tools";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 12;
            ProductItems.ProductId = 36;
            ProductItems.Price = 10734.00;
            ProductItems.ProductName = "Franke AK-100S Rail System Utensil Holder with Hooks";
            ProductItems.ProductDescription = "Kitchen Tools";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 13;
            ProductItems.ProductId = 37;
            ProductItems.Price = 750.00;
            ProductItems.ProductName = "Brazucareplikas Brazuca Football - Size: 5";
            ProductItems.ProductDescription = "Football Products";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 13;
            ProductItems.ProductId = 38;
            ProductItems.Price = 825.00;
            ProductItems.ProductName = "Vinex NA Dual Sided Clipboard (Spring Release Clip)";
            ProductItems.ProductDescription = "Football Products";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 14;
            ProductItems.ProductId = 39;
            ProductItems.Price = 800.00;
            ProductItems.ProductName = "Purplle Hair For Sure (150 ml)(Hair Treatment Hair Repair, Hair Gain, Hair growth)";
            ProductItems.ProductDescription = "Cricket Products";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 14;
            ProductItems.ProductId = 40;
            ProductItems.Price = 619.00;
            ProductItems.ProductName = "BC Repair Rescue Treatment - For Damaged Hair (New Packaging) 200ml/6";
            ProductItems.ProductDescription = "Cricket Products";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 15;
            ProductItems.ProductId = 41;
            ProductItems.Price = 1499.00;
            ProductItems.ProductName = "Adidas Neoprene Dumbbell - 3.0kg";
            ProductItems.ProductDescription = "BodyBuilding & Fitness";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 15;
            ProductItems.ProductId = 42;
            ProductItems.Price = 4499.00;
            ProductItems.ProductName = "Adidas Kettlebell - 8kg";
            ProductItems.ProductDescription = "BodyBuilding & Fitness";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 15;
            ProductItems.ProductId = 43;
            ProductItems.Price = 3599.00;
            ProductItems.ProductName = "Adidas Door Gym Weight Lifting Bar";
            ProductItems.ProductDescription = "BodyBuilding & Fitness";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 16;
            ProductItems.ProductId = 44;
            ProductItems.Price = 98295.00;
            ProductItems.ProductName = " K-SWISS Men s Vertical Tubes Cali-Mari Low Running Shoeby";
            ProductItems.ProductDescription = "Running Products";
            listOfProductItems.Add(ProductItems);

            ProductItems = new ProductItems();
            ProductItems.SubCategoryId = 16;
            ProductItems.ProductId = 45;
            ProductItems.Price = 35376.00;
            ProductItems.ProductName = "TYR TMZSJB6A Carbon Zipper Back Shorts John W/Pad, X-Small (Black/Red)";
            ProductItems.ProductDescription = "Running Products";
            listOfProductItems.Add(ProductItems);

            return listOfProductItems;
        }       
    }
}
