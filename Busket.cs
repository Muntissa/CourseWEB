using CourseWEB.Entities;

namespace CourseWEB
{
    public static class Busket
    {
        public static void FillDb()
        {
            using(var context = new Context())
            {
                if(context.Clothes.Any())
                    return;
                
                var categoryTopCloth = new Category() { Name = "Верхнаяя одежда" };
                var categoryMantle = new Category() { Name = "Мантии" };
                var categoryKimono = new Category() { Name = "Кимоно" };
                var categoryHoodies = new Category() { Name = "Толстовки" };
                var categoryTshirts = new Category() { Name = "Футболки" };
                var categoryShirts = new Category() { Name = "Рубашки" };
                var categoryPants = new Category() { Name = "Брюки" };
                var categoryPidjacs = new Category() { Name = "Пиджаки" };
                var categoryShoes = new Category() { Name = "Обувь" };
                var categoryAccess = new Category() { Name = "Аксессуары" };
             
                context.Categories.Add(categoryTopCloth);
                context.Categories.Add(categoryMantle);
                context.Categories.Add(categoryKimono);
                context.Categories.Add(categoryHoodies);
                context.Categories.Add(categoryTshirts);
                context.Categories.Add(categoryShirts);
                context.Categories.Add(categoryPants);
                context.Categories.Add(categoryPidjacs);
                context.Categories.Add(categoryShoes);
                context.Categories.Add(categoryAccess);

                var cloth1 = new Clothes() 
                { 
                    Name = "КОСУХА С МЕХОМ BLACKOUT. ЧЕРНО-БЕЛАЯ",
                    Description = "Куртка-косуха унисекс в стиле глэм-рок из эко-кожи. Прямой силуэт, косая застежка на молнию. По бокам внутренние прорезные карманы. На рукавах паты с металлическими пряжками и возможностью регулирования.<br/>Материалы: 100% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L", 
                    Price = "22 990 р.",
                    Category = categoryTopCloth,

                }; 
                var image1 = new Image() { Cloth = cloth1, Url = "./image/topcloth1-1.jpg" };
                var image2 = new Image() { Cloth = cloth1, Url = "./image/topcloth1-2.jpg" };
                context.Images.Add(image1);
                context.Images.Add(image2);
                context.Clothes.Add(cloth1);

                var cloth2 = new Clothes()
                {
                    Name = "КУРТКА УТЕПЛЕННАЯ СО СТРОПАМИ BLACKOUT. ЧЕРНАЯ",
                    Description = "Куртка унисекс в стиле tech. Застежка на стропы с кнопками. По бокам прорезные карманы. На рукавах стропы с декоративными кнопками.<br/>Материалы: 100% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "19 990 р.",
                    Category = categoryTopCloth
                };
                var image3 = new Image() { Cloth = cloth2, Url = "./image/topcloth2-1.jpg" };
                var image4 = new Image() { Cloth = cloth2, Url = "./image/topcloth2-2.jpg" };
                context.Images.Add(image3);
                context.Images.Add(image4);
                context.Clothes.Add(cloth2);

                var cloth3 = new Clothes()
                {
                    Name = "КУРТКА-ЛЕТУЧАЯ МЫШЬ BLACKOUT. ЧЕРНАЯ",
                    Description = "Укороченная куртка унисекс в стиле футуризм. Силуэт оверсайз, с капюшоном. Застегивается на молнию. Боковые прорезные карманы на молнии. Внутренние манжеты для защиты от ветра из мягкого флисового меха. Потайной карман на молнии. По низу кулиска с регулятором. Подклад с ионами серебра, удерживающий тепло.<br/>Материалы: 100% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "23 990 р.",
                    Category = categoryTopCloth
                };
                var image5 = new Image() { Cloth = cloth3, Url = "./image/topcloth3-1.jpg" };
                var image6 = new Image() { Cloth = cloth3, Url = "./image/topcloth3-2.jpg" };
                context.Images.Add(image5);
                context.Images.Add(image6);
                context.Clothes.Add(cloth3);

                var cloth4 = new Clothes()
                {
                    Name = "УТЕПЛЕННАЯ КУРТКА VACUUM ЛОНГ. ЧЕРНАЯ",
                    Description = "Унисекс. Прямой силуэт, зауженный к низу. Модель oversize. Утепленная модель на молнии с дополнительной застежкой на кнопках. Удобные боковые карманы и один внутренний на молнии. Водоотталкивающий и ветрозащитный материал верха. Подклад с ионами серебра, удерживающий тепло. Современный утеплитель — холлофайбер.<br/>Материалы: 100% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "XS,S,M",
                    Price = "18 990 р.",
                    Category = categoryTopCloth
                };
                var image7 = new Image() { Cloth = cloth4, Url = "./image/topcloth4-1.jpg" };
                var image8 = new Image() { Cloth = cloth4, Url = "./image/topcloth4-2.jpg" };
                context.Images.Add(image7);
                context.Images.Add(image8);
                context.Clothes.Add(cloth4);

                var cloth5 = new Clothes()
                {
                    Name = "ПАЛЬТО С НАШИВКАМИ EXISTENCE. ЧЕРНО-КРАСНОЕ",
                    Description = "Пальто демисезонное унисекс в стиле панк, прямого силуэта, из сочетания клетчатой и однотонной ткани, на подкладке, застежка на молнию, воротник-стойка с застёжкой на кнопки, прорезные боковые карманы, шлица на спинке, декорировано нашивками.<br/>Материалы: 70% полиэстер, 27% вискоза, 3% эластан<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "23 990 р.",
                    Category = categoryTopCloth
                };
                var image9 = new Image() { Cloth = cloth5, Url = "./image/topcloth5-1.jpg" };
                var image10 = new Image() { Cloth = cloth5, Url = "./image/topcloth5-2.jpg" };
                context.Images.Add(image9);
                context.Images.Add(image10);
                context.Clothes.Add(cloth5);

                var cloth6 = new Clothes()
                {
                    Name = "БОМБЕР С КАПЮШОНОМ BUSIDO. ЧЕРНЫЙ",
                    Description = "Утепленный бомбер унисекс длиной до середины бедра, в стиле японского минимализма, прямого силуэта, с косой застежкой на молнию, с длинным рукавом, тремя прорезными карманами, съемным капюшоном и асимметричной линией низа.<br/>Материалы: 100% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "14 990 р.",
                    Category = categoryTopCloth
                };
                var image11 = new Image() { Cloth = cloth6, Url = "./image/topcloth6-1.jpg" };
                var image12 = new Image() { Cloth = cloth6, Url = "./image/topcloth6-2.jpg" };
                context.Images.Add(image11);
                context.Images.Add(image12);
                context.Clothes.Add(cloth6);

                var cloth7 = new Clothes()
                {
                    Name = "МАНТИЯ SHINOBI. ЧЕРНАЯ",
                    Description = "Мантия унисекс в стиле tech. Боковая застежка-фастекс с возможностью регулировать ширину в талии. Дополнительная внутренняя застежка. Расширяющиеся к низу рукава с декоративными стропами, позволяющими регулировать длину. Накладные боковые карманы с клапанами, выполнены из плащевой ткани. Декоративные элементы из строп на спине регулируются по длине с помощью боковых рамок, на концах имеют полукольца.<br/>Материалы: 80% хлопок, 20% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "11 990 р.",
                    Category = categoryMantle
                };
                var image13 = new Image() { Cloth = cloth7, Url = "./image/mantle1-1.jpg" };
                var image14 = new Image() { Cloth = cloth7, Url = "./image/mantle1-2.jpg" };
                context.Images.Add(image13);
                context.Images.Add(image14);
                context.Clothes.Add(cloth7);

                var cloth8 = new Clothes()
                {
                    Name = "МАНТИЯ ДЕМЕНТОР ЛОНГ. ЧЕРНАЯ",
                    Description = "Унисекс. Мантия с капюшоном. Свободный удлиненный крой. Удобные карманы. Застегивается оригинально — внахлест.<br/>Материалы: 95% хлопок, 5% лайкра<br/>Сделано в Санкт-Петербурге",
                    Sizes = "XS,S,M",
                    Price = "8 990 р.",
                    Category = categoryMantle
                };
                var image15 = new Image() { Cloth = cloth8, Url = "./image/mantle2-1.jpg" };
                var image16 = new Image() { Cloth = cloth8, Url = "./image/mantle2-2.jpg" };
                context.Images.Add(image15);
                context.Images.Add(image16);
                context.Clothes.Add(cloth8);

                var cloth9 = new Clothes()
                {
                    Name = "МАНТИЯ НА МОЛНИИ",
                    Description = "Унисекс. Объемный воротник фиксируется кнопками. Удобные карманы.<br/>Материалы: 80% хлопок, 20% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "9 990 р.",
                    Category = categoryMantle
                };
                var image17 = new Image() { Cloth = cloth9, Url = "./image/mantle3-1.jpg" };
                var image18 = new Image() { Cloth = cloth9, Url = "./image/mantle3-2.jpg" };
                context.Images.Add(image17);
                context.Images.Add(image18);
                context.Clothes.Add(cloth9);

                var cloth10 = new Clothes()
                {
                    Name = "МАНТИЯ SHINOBI. ЧЕРНАЯ",
                    Description = "Унисекс, свободный удлиненный крой. Необработанный край на рукавах и карманах. Удобные передние карманы.<br/>Материалы: 80% хлопок, 20% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "XS,S,M",
                    Price = "7 990 р.",
                    Category = categoryMantle
                };
                var image19 = new Image() { Cloth = cloth10, Url = "./image/mantle4-1.jpg" };
                var image20 = new Image() { Cloth = cloth10, Url = "./image/mantle4-2.jpg" };
                context.Images.Add(image19);
                context.Images.Add(image20);
                context.Clothes.Add(cloth10);

                var cloth11 = new Clothes()
                {
                    Name = "КУРТКА-КИМОНО NOMAD. ЧЕРНАЯ",
                    Description = "Куртка-кимоно унисекс из водоотталкивающего материала, прямого силуэта, на тонком утеплителе, со съемными рукавами на скрытых кнопках, застежка на кнопки, дополнена декоративными завязками, боковые прорезные карманы.<br/>Материалы: 60% хлопок, 40% нейлон<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "12 990 р.",
                    Category = categoryKimono
                };
                var image21 = new Image() { Cloth = cloth11, Url = "./image/kimono1-1.jpg" };
                var image22 = new Image() { Cloth = cloth11, Url = "./image/kimono1-2.jpg" };
                context.Images.Add(image21);
                context.Images.Add(image22);
                context.Clothes.Add(cloth11);

                var cloth12 = new Clothes()
                {
                    Name = "КИМОНО С НАШИВКАМИ YOUKAI. ЧЕРНОЕ",
                    Description = "Кимоно унисекс в стиле японского минимализма, свободного силуэта, с асимметричной линией борта, с широким рукавом длиной ⅞, карманами в швах и застежкой борта на фастекс. Кимоно декорировано принтами-нашивками.<br/>Материалы: 64% полиэстер, 32% вискоза, 4% эластан<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "10 990 р.",
                    Category = categoryKimono
                };
                var image23 = new Image() { Cloth = cloth12, Url = "./image/kimono2-1.jpg" };
                var image24 = new Image() { Cloth = cloth12, Url = "./image/kimono2-2.jpg" };
                context.Images.Add(image23);
                context.Images.Add(image24);
                context.Clothes.Add(cloth12);

                var cloth13 = new Clothes()
                {
                    Name = "ПИДЖАК-КИМОНО JAPAN. ЧЕРНЫЙ",
                    Description = "Пиджак унисекс в стиле японского минимализма, трапециевидного силуэта, длиной до середины бедра, с рукавом длиной ⅞, воротником-стойкой, без застежки, с двумя прорезными карманами.<br/>Материалы: 64% полиэстер, 32% вискоза, 4% эластан<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "11 990 р.",
                    Category = categoryKimono
                };
                var image25 = new Image() { Cloth = cloth13, Url = "./image/kimono3-1.jpg" };
                var image26 = new Image() { Cloth = cloth13, Url = "./image/kimono3-2.jpg" };
                context.Images.Add(image25);
                context.Images.Add(image26);
                context.Clothes.Add(cloth13);

                var cloth14 = new Clothes()
                {
                    Name = "ХУДИ МНОГОСЛОЙНОЕ BLACKOUT. ЧЕРНОЕ",
                    Description = "Многослойное худи унисекс в стиле деконструктивизм. Верхняя отлетная деталь переходит в накладной карман спереди.<br/>Материалы: 88% хлопок, 12% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "9 490 р.",
                    Category = categoryHoodies
                };
                var image27 = new Image() { Cloth = cloth14, Url = "./image/hoodie1-1.jpg" };
                var image28 = new Image() { Cloth = cloth14, Url = "./image/hoodie1-2.jpg" };
                context.Images.Add(image27);
                context.Images.Add(image28);
                context.Clothes.Add(cloth14);

                var cloth15 = new Clothes()
                {
                    Name = "СВИТШОТ С ДЕТАЛЬЮ REFLECTION. ЧЕРНЫЙ",
                    Description = "Свитшот унисекс в стиле tech. Декоративные детали и накладной карман с клапаном на кнопках из фактурной ткани соединены с помощью стропы и фастекса.<br/>Материалы: 88% хлопок, 12% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "6 990 р.",
                    Category = categoryHoodies
                };
                var image29 = new Image() { Cloth = cloth15, Url = "./image/hoodie2-1.jpg" };
                var image30 = new Image() { Cloth = cloth15, Url = "./image/hoodie2-2.jpg" };
                context.Images.Add(image29);
                context.Images.Add(image30);
                context.Clothes.Add(cloth15);

                var cloth16 = new Clothes()
                {
                    Name = "ХУДИ МНОГОСЛОЙНОЕ СО СТРОПАМИ KAMI. ЧЕРНОЕ",
                    Description = "Многослойное худи унисекс в стиле деконструктивизм, прямого силуэта, верхний слой соединяется стропами с застежками-фастексами по бокам, нижний слой из трикотажа со слаб-эффектом.<br/>Материалы: 95% бамбук, 5% лайкра<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "10 490 р.",
                    Category = categoryHoodies
                };
                var image31 = new Image() { Cloth = cloth16, Url = "./image/hoodie3-1.jpg" };
                var image32 = new Image() { Cloth = cloth16, Url = "./image/hoodie3-2.jpg" };
                context.Images.Add(image31);
                context.Images.Add(image32);
                context.Clothes.Add(cloth16);

                var cloth17 = new Clothes()
                {
                    Name = "МНОГОСЛОЙНОЕ ХУДИ С ИНОПЛАНЕТНЫМ ПРИНТОМ JAPAN. ЧЕРНОЕ",
                    Description = "Худи унисекс с принтом, в стиле японского минимализма, прямого силуэта, с двойным рукавом, карманом и капюшоном с воротником-стойкой.<br/>Материалы: 80% хлопок, 20% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "9 490 р.",
                    Category = categoryHoodies
                };
                var image33 = new Image() { Cloth = cloth17, Url = "./image/hoodie4-1.jpg" };
                var image34 = new Image() { Cloth = cloth17, Url = "./image/hoodie4-2.jpg" };
                context.Images.Add(image33);
                context.Images.Add(image34);
                context.Clothes.Add(cloth17);

                var cloth18 = new Clothes()
                {
                    Name = "ФУТБОЛКА С НАШИВКАМИ EXISTENCE. ЧЕРНАЯ",
                    Description = "Футболка унисекс в стиле панк, свободного силуэта, посадка oversize, дополнена декоративными нашивками.<br/>Материалы: 95% хлопок, 5% лайкра<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "5 290 р.",
                    Category = categoryTshirts
                };
                var image35 = new Image() { Cloth = cloth18, Url = "./image/tshirt1-1.jpg" };
                var image36 = new Image() { Cloth = cloth18, Url = "./image/tshirt1-2.jpg" };
                context.Images.Add(image35);
                context.Images.Add(image36);
                context.Clothes.Add(cloth18);

                var cloth19 = new Clothes()
                {
                    Name = "ФУТБОЛКА С НАШИВКАМИ YOUKAI. ЧЕРНАЯ",
                    Description = "Футболка унисекс, в стиле японского минимализма, прямого силуэта, с круглой горловиной, декорирована принтами-нашивками.<br/>Материалы: 95% хлопок, 5% лайкра<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "5 290 р.",
                    Category = categoryTshirts
                };
                var image37 = new Image() { Cloth = cloth19, Url = "./image/tshirt2-1.jpg" };
                var image38 = new Image() { Cloth = cloth19, Url = "./image/tshirt2-2.jpg" };
                context.Images.Add(image37);
                context.Images.Add(image38);
                context.Clothes.Add(cloth19);

                var cloth20 = new Clothes()
                {
                    Name = "ФУТБОЛКА С РАЗРЕЗАМИ VISION. ЧЕРНАЯ",
                    Description = "Футболка унисекс свободного силуэта, с застроченными складками и разрезами, принт выполнен в технике шелкография.<br/>Материалы: 95% хлопок, 5% лайкра<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "5 490 р.",
                    Category = categoryTshirts
                };
                var image39 = new Image() { Cloth = cloth20, Url = "./image/tshirt3-1.jpg" };
                var image40 = new Image() { Cloth = cloth20, Url = "./image/tshirt3-2.jpg" };
                context.Images.Add(image39);
                context.Images.Add(image40);
                context.Clothes.Add(cloth20);

                var cloth21 = new Clothes()
                {
                    Name = "ФУТБОЛКА СО ВСТАВКОЙ OBLIVION. ЧЕРНАЯ",
                    Description = "Футболка унисекс в стиле деконструктивизм, прямого силуэта, с круглой горловиной. Контрастные декоративные детали . Изготовлено из материалов с фиксацией цвета, которые не линяют при стирке.<br/>Материалы: 92% хлопок, 8% лайкра<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "5 990 р.",
                    Category = categoryTshirts
                };
                var image41 = new Image() { Cloth = cloth21, Url = "./image/tshirt1-1.jpg" };
                var image42 = new Image() { Cloth = cloth21, Url = "./image/tshirt1-1.jpg" };
                context.Images.Add(image41);
                context.Images.Add(image42);
                context.Clothes.Add(cloth21);

                var cloth22 = new Clothes()
                {
                    Name = "РУБАШКА ИЗ ТКАНИ С ВОЛОКНОМ ЭВКАЛИПТА HANAMI. БЕЛАЯ",
                    Description = "Рубашка унисекс в стиле японского минимализма из легкой ткани с эвкалиптовыми волокнами. Застежка борта и манжет на пуговицы. Стояче-отложной воротник.<br/>Материалы: 75% тенсел 25% нейлон<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "5 390 р.",
                    Category = categoryShirts
                };
                var image43 = new Image() { Cloth = cloth22, Url = "./image/rubashka1-1.jpg" };
                var image44 = new Image() { Cloth = cloth22, Url = "./image/rubashka1-2.jpg" };
                context.Images.Add(image43);
                context.Images.Add(image44);
                context.Clothes.Add(cloth22);

                var cloth23 = new Clothes()
                {
                    Name = "РУБАШКА АСИММЕТРИЧНАЯ MATSURI. БЕЛАЯ",
                    Description = "Рубашка унисекс в стиле деконструктивизм, укороченный рукав, асимметричные линия низа и застежка борта на пуговицы, стояче-отложной воротник.<br/>Материалы: 65% полиэстер, 35% хлопок<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "7 990 р.",
                    Category = categoryShirts
                };
                var image45 = new Image() { Cloth = cloth23, Url = "./image/rubashka2-1.jpg" };
                var image46 = new Image() { Cloth = cloth23, Url = "./image/rubashka2-2.jpg" };
                context.Images.Add(image45);
                context.Images.Add(image46);
                context.Clothes.Add(cloth23);

                var cloth24 = new Clothes()
                {
                    Name = "РУБАШКА ИЗ ТКАНИ С ВОЛОКНОМ ЭВКАЛИПТА HANAMI. ЧЕРНАЯ",
                    Description = "Рубашка унисекс в стиле японского минимализма из легкой ткани с эвкалиптовыми волокнами. Застежка борта и манжет на пуговицы. Стояче-отложной воротник.<br/>Материалы: 75% тенсел 25% нейлон<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "4 490 р.",
                    Category = categoryShirts
                };
                var image47 = new Image() { Cloth = cloth24, Url = "./image/rubashka3-3.jpg" };
                var image48 = new Image() { Cloth = cloth24, Url = "./image/rubashka3-4.jpg" };
                context.Images.Add(image47);
                context.Images.Add(image48);
                context.Clothes.Add(cloth24);

                var cloth25 = new Clothes()
                {
                    Name = "ДЖОГГЕРЫ С ДЕТАЛЬЮ REFLECTION. ЧЕРНЫЕ",
                    Description = "Джоггеры унисекс в стиле tech. По бокам внутренние карманы. Накладная деталь из фактурной ткани по переду. Асимметричные накладные карманы с клапаном на кнопках и молнией. Эластичный пояс регулируется с помощью вощеного шнура.<br/>Материалы: 88% хлопок, 12% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "9 490 р.",
                    Category = categoryPants
                };
                var image49 = new Image() { Cloth = cloth25, Url = "./image/pants1-1.jpg" };
                var image50 = new Image() { Cloth = cloth25, Url = "./image/pants1-2.jpg" };
                context.Images.Add(image49);
                context.Images.Add(image50);
                context.Clothes.Add(cloth25);

                var cloth26 = new Clothes()
                {
                    Name = "ДЖИНСЫ-ТРАНСФОРМЕРЫ ORIGAMI. ЧЕРНЫЕ",
                    Description = "Джинсы унисекс свободного кроя в стиле деконструктивизм. Представлены в двух вариантах - из утеплённого и не утеплённого денима. Боковые прорезные карманы. Шлевки на поясе. Застежка на кнопку. Штанины трансформируются с помощью кнопок. Декоративные контрастные строчки. Задние накладные карманы.<br/>Материалы: 100% хлопок<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "12 990 р.",
                    Category = categoryPants
                };
                var image51 = new Image() { Cloth = cloth26, Url = "./image/pants2-1.jpg" };
                var image52 = new Image() { Cloth = cloth26, Url = "./image/pants2-2.jpg" };
                context.Images.Add(image51);
                context.Images.Add(image52);
                context.Clothes.Add(cloth26);

                var cloth27 = new Clothes()
                {
                    Name = "БРЮКИ С РАЗРЕЗАМИ OBLIVION. ЧЕРНЫЕ",
                    Description = "Брюки унисекс в стиле глэм-рок прямого силуэта со шлицей по бокам. Боковые прорезные карманы на металлической молнии. Шлевки на поясе. Застёжка на кнопку.<br/>Материалы: 75% полиэстер, 20% вискоза, 5% спандекс<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "9 990 р.",
                    Category = categoryPants
                };
                var image53 = new Image() { Cloth = cloth27, Url = "./image/pants3-1.jpg" };
                var image54 = new Image() { Cloth = cloth27, Url = "./image/pants3-2.jpg" };
                context.Images.Add(image53);
                context.Images.Add(image54);
                context.Clothes.Add(cloth27);

                var cloth28 = new Clothes()
                {
                    Name = "ДЖОГГЕРЫ BASE. ГРАФИТ",
                    Description = "Джоггеры базовые унисекс из хлопковой ткани, боковые прорезные карманы, пояс на резинке регулируется с помощью шнура.<br/>Материалы: 88% хлопок, 12% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "6 990 р.",
                    Category = categoryPants
                };
                var image55 = new Image() { Cloth = cloth28, Url = "./image/pants4-1.jpg" };
                var image56 = new Image() { Cloth = cloth28, Url = "./image/pants4-2.jpg" };
                context.Images.Add(image55);
                context.Images.Add(image56);
                context.Clothes.Add(cloth28);

                var cloth29 = new Clothes()
                {
                    Name = "ПИДЖАК ИЗ ЭКО-КОЖИ NOIR. ЧЕРНЫЙ",
                    Description = "Пиджак унисекс в стиле глэм-рок из эко-кожи, прямого силуэта. Отложной воротник. Застёжка на кнопки. Боковые прорезные карманы с клапанами.<br/>Материалы: 100% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "14 990 р.",
                    Category = categoryPidjacs
                };
                var image57 = new Image() { Cloth = cloth29, Url = "./image/pidjac1-1.jpg" };
                var image58 = new Image() { Cloth = cloth29, Url = "./image/pidjac1-2.jpg" };
                context.Images.Add(image57);
                context.Images.Add(image58);
                context.Clothes.Add(cloth29);

                var cloth30 = new Clothes()
                {
                    Name = "ПИДЖАК С МОЛНИЯМИ ELEMENT. ЧЕРНЫЙ",
                    Description = "Пиджак унисекс в стиле глэм-рок, силуэт оверсайз, отложной воротник. Застёжка на пуговицы. Асимметричные прорезные карманы на молнии. Функциональная металлическая молния на спине.<br/>Материалы: 75% полиэстер, 20% вискоза, 5% спандекс<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "13 990 р.",
                    Category = categoryPidjacs
                };
                var image59 = new Image() { Cloth = cloth30, Url = "./image/pidjac2-1.jpg" };
                var image60 = new Image() { Cloth = cloth30, Url = "./image/pidjac2-2.jpg" };
                context.Images.Add(image59);
                context.Images.Add(image60);
                context.Clothes.Add(cloth30);

                var cloth31 = new Clothes()
                {
                    Name = "ПИДЖАК OVERSIZE JAPAN. ЧЕРНЫЙ",
                    Description = "Асимметричный пиджак унисекс в стиле японского минимализма, силуэт оверсайз, отложной воротник, застежка на пуговицы, боковые прорезные карманы.<br/>Материалы: 75% полиэстер, 20% вискоза, 5% спандекс<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "14 990 р.",
                    Category = categoryPidjacs
                };
                var image61 = new Image() { Cloth = cloth31, Url = "./image/pidjac3-1.jpg" };
                var image62 = new Image() { Cloth = cloth31, Url = "./image/pidjac3-2.jpg" };
                context.Images.Add(image61);
                context.Images.Add(image62);
                context.Clothes.Add(cloth31);

                var cloth32 = new Clothes()
                {
                    Name = "ПИДЖАК-КИМОНО JAPAN. ЧЕРНЫЙ",
                    Description = "Пиджак унисекс в стиле японского минимализма, трапециевидного силуэта, длиной до середины бедра, с рукавом длиной ⅞, воротником-стойкой, без застежки, с двумя прорезными карманами.<br/>Материалы: 64% полиэстер, 32% вискоза, 4% эластан<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "11 990 р.",
                    Category = categoryPidjacs
                };
                var image63 = new Image() { Cloth = cloth32, Url = "./image/pidjac4-1.jpg" };
                var image64 = new Image() { Cloth = cloth32, Url = "./image/pidjac4-2.jpg" };
                context.Images.Add(image63);
                context.Images.Add(image64);
                context.Clothes.Add(cloth32);

                var cloth33 = new Clothes()
                {
                    Name = "КЕДЫ YAMATO. ЧЕРНО-БЕЛЫЕ",
                    Description = "Кеды унисекс высокие из текстильного материала в стиле деконструктивизм. Резиновая подошва, накладные металлические петли со шнуровкой. Застежка на молнию сбоку.<br/>Материалы: Верх: 100% натуральная кожа, 100% хлопок. Подкладка и стелька: 70% хлопок, 30% нейлон, 100% натуральная кожа. Подошва: 100% полимерная резина.<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "15 990 р.",
                    Category = categoryShoes
                };
                var image65 = new Image() { Cloth = cloth33, Url = "./image/shoes1-1.jpg" };
                var image66 = new Image() { Cloth = cloth33, Url = "./image/shoes1-2.jpg" };
                context.Images.Add(image65);
                context.Images.Add(image66);
                context.Clothes.Add(cloth33);

                var cloth34 = new Clothes()
                {
                    Name = "ТАБИ НА КАБЛУКЕ JAPAN. ЧЕРНЫЕ",
                    Description = "Высокие полуботинки на каблуке унисекс в традиционном японском стиле. Застежка на металлическую молнию сбоку. Материал верха-натуральная кожа. В комплект входят специальные носки.<br/>Материалы: Верх: 100% натуральная кожа. Подкладка и стелька: 70% хлопок, 30% нейлон, 100% натуральная кожа. Подошва: 100% полимерная резина.<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "18 990 р.",
                    Category = categoryShoes
                };
                var image67 = new Image() { Cloth = cloth34, Url = "./image/shoes2-1.jpg" };
                var image68 = new Image() { Cloth = cloth34, Url = "./image/shoes2-2.jpg" };
                context.Images.Add(image67);
                context.Images.Add(image68);
                context.Clothes.Add(cloth34);

                var cloth35 = new Clothes()
                {
                    Name = "БОТИНКИ С ДЕТАЛЯМИ NOIR. ЧЕРНЫЕ",
                    Description = "Ботинки унисекс в стиле глэм-рок, с закруглённым носком, с накладной деталью, застегивающейся на кнопки, внутренней шнуровкой и застежкой на металлическую молнию сбоку. Стелька, носок и пятка 100% натуральная кожа. Сделаны вручную.<br/>Материалы: Верх: 100% эко-кожа, 100% натуральная кожа. Подкладка и стелька: 70% хлопок, 30% нейлон, 100% натуральная кожа. Подошва: 100% полимерная резина.<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "19 990 р.",
                    Category = categoryShoes
                };
                var image69 = new Image() { Cloth = cloth35, Url = "./image/shoes3-1.jpg" };
                var image70 = new Image() { Cloth = cloth35, Url = "./image/shoes3-2.jpg" };
                context.Images.Add(image69);
                context.Images.Add(image70);
                context.Clothes.Add(cloth35);

                var cloth36 = new Clothes()
                {
                    Name = "КЕДЫ С НАШИВКАМИ EXISTENCE. ЧЕРНЫЕ",
                    Description = "Высокие кеды с нашивками в стиле панк из текстильного материала с необработанным краем, на резиновой подошве, детали из натуральной кожи, застежка на молнию сбоку.<br/>Материалы: Верх: 100% натуральная кожа, 100% хлопок. Подкладка и стелька: 70% хлопок, 30% нейлон, 100% натуральная кожа. Подошва: 100% полимерная резина.<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "15 990 р.",
                    Category = categoryShoes
                };
                var image71 = new Image() { Cloth = cloth36, Url = "./image/shoes4-1.jpg" };
                var image72 = new Image() { Cloth = cloth36, Url = "./image/shoes4-2.jpg" };
                context.Images.Add(image71);
                context.Images.Add(image72);
                context.Clothes.Add(cloth36);

                var cloth37 = new Clothes()
                {
                    Name = "БАЛАКЛАВА ВЯЗАНАЯ BLACKOUT. ЧЕРНАЯ",
                    Description = "Вязаная балаклава унисекс. Функциональная прорезь для глаз также позволяет открыть лицо полностью.<br/>Материалы: 50% шерсть, 50% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "5 990 р.",
                    Category = categoryAccess
                };
                var image73 = new Image() { Cloth = cloth37, Url = "./image/access1-1.jpg" };
                var image74 = new Image() { Cloth = cloth37, Url = "./image/access1-2.jpg" };
                context.Images.Add(image73);
                context.Images.Add(image74);
                context.Clothes.Add(cloth37);

                var cloth38 = new Clothes()
                {
                    Name = "РЮКЗАК СТЕГАНЫЙ BLACKOUT. ЧЕРНЫЙ",
                    Description = "Стёганый рюкзак унисекс из матовой эко-кожи. Внутри одно основное отделение на молнии с карманом для ноутбука и небольшим карманом на молнии. Клапан соединяется с основным отделение при помощи застёжек-фастексов и строп. Габариты рюкзака: 42*32*12 см.<br/>Материалы: 100% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "7 990 р.",
                    Category = categoryAccess
                };
                var image75 = new Image() { Cloth = cloth38, Url = "./image/access2-1.jpg" };
                var image76 = new Image() { Cloth = cloth38, Url = "./image/access2-2.jpg" };
                context.Images.Add(image75);
                context.Images.Add(image76);
                context.Clothes.Add(cloth38);

                var cloth39 = new Clothes()
                {
                    Name = "РЮКЗАК KUMA. ЧЕРНЫЙ",
                    Description = "Рюкзак унисекс из эко-кожи, большое внутреннее отделение на молнии (50х37), ремешки из стропы, пристёгиваются с помощью карабинов, длина ремешков регулируется.<br/>Материалы: 100% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "11 990 р.",
                    Category = categoryAccess
                };
                var image77 = new Image() { Cloth = cloth39, Url = "./image/access3-1.jpg" };
                var image78 = new Image() { Cloth = cloth39, Url = "./image/access3-2.jpg" };
                context.Images.Add(image77);
                context.Images.Add(image78);
                context.Clothes.Add(cloth39);

                var cloth40 = new Clothes()
                {
                    Name = "КАСА JAPAN. ЧЕРНАЯ",
                    Description = "Головной убор унисекс в традиционном японском стиле с регулируемым креплением. Размеры: ширина полей 74 см, длина крепления 26 см.<br/>Материалы: 100% полиэстер<br/>Сделано в Санкт-Петербурге",
                    Sizes = "S,M,L",
                    Price = "5 490 р.",
                    Category = categoryAccess
                };
                var image79 = new Image() { Cloth = cloth40, Url = "./image/access4-1.jpg" };
                var image80 = new Image() { Cloth = cloth40, Url = "./image/access4-2.jpg" };
                context.Images.Add(image79);
                context.Images.Add(image80);
                context.Clothes.Add(cloth40);



                var news1 = new News()
                {
                    Name = "Мода как искусство: фантазийная коллекция Harris Reed, которая нарушает законы притяжения",
                    ShortDecription = "Показ открыл Неделю моды в Лондоне",
                    Description = "В универмагах СТОКМАНН и интернет-магазине уже можно приобрести новинки из коллекций осень-зима 2022. В этом сезоне покупателей ждут как уже ставшие визитной карточкой сети популярные международные и российские бренды, так и новые имена. Пополнится не только модный отдел, но и отдел товаров для дома СТОКМАНН, который порадует новыми поступлениями домашнего текстиля, посуды и декора от европейских марок. Осенью также стартует продолжение проекта СТОКМАНН People, в рамках которого амбассадорами бренда становятся обычные люди: покупатели, байеры, дизайнеры, продавцы универмага. В этот раз в кампании снялись сотрудники разных отделов СТОКМАНН.",
                    Date = "16 сентября 2022"
                };
                var image81 = new Image() { News = news1, Url = "./image/news1.jpg" };
                var image82 = new Image() { News = news1, Url = "./image/newsdetailed1.jpg" };
                context.Images.Add(image81);
                context.Images.Add(image82);
                context.News.Add(news1);

                var news2 = new News()
                {
                    Name = "Платья с омбре, прозрачные топы и оверсайз жакеты Peter Do SS23: все, что мы будем носить весной 2023",
                    ShortDecription = "Весенняя коллекция Peter Do 2023",
                    Description = "По мнению дизайнеров модного Дома Peter Do, следующей весной наш гардероб будет состоять из объемных двубортных жакетов и плащей, как из 90-х. А еще из лаконичных платьев с эффектным принтом омбре, который всегда добавляет образу особого шика. И все эти вещи можно будет носить вместе, чтобы развивать навык многослойного стайлинга.",
                    Date = "14 сентября 2022"
                };
                var image83 = new Image() { News = news2, Url = "./image/news2.jpg" };
                var image84 = new Image() { News = news2, Url = "./image/newsdetailed2.jpg" };
                context.Images.Add(image83);
                context.Images.Add(image84);
                context.News.Add(news2);

                var news3 = new News()
                {
                    Name = "Новые коллекции в СТОКМАНН и другие модные новости недели",
                    ShortDecription = "Что произошло в мире шопинга за последние дни?",
                    Description = "В универмагах СТОКМАНН и интернет-магазине уже можно приобрести новинки из коллекций осень-зима 2022. В этом сезоне покупателей ждут как уже ставшие визитной карточкой сети популярные международные и российские бренды, так и новые имена. Пополнится не только модный отдел, но и отдел товаров для дома СТОКМАНН, который порадует новыми поступлениями домашнего текстиля, посуды и декора от европейских марок.",
                    Date = "16 сентября 2022"
                };
                var image85 = new Image() { News = news3, Url = "./image/news3.jpg" };
                var image86 = new Image() { News = news3, Url = "./image/newsdetailed3.jpg" };
                context.Images.Add(image85);
                context.Images.Add(image86);
                context.News.Add(news3);

                var news4 = new News()
                {
                    Name = "2 корсетных платья Dolce&Gabbana новой «королевы ужасов» Мии Гот",
                    ShortDecription = "Актриса подыгрывает своему персонажу по имени Перл на красной дорожке Венецианского кинофестиваля. Красиво… Особенно, если не знать сюжет фильма, который она здесь представляет",
                    Description = "События в фильме «Перл» разворачиваются в 1918 году, и даже сама съемка ленты мастерски стилизована под то время. «Стилизованной» под соответствующую эпоху оказалась и заглавная актриса Миа, которая в эти дни представила картину на 79-м Венецианском кинофестивале. И для дневной, и для вечерней части премьеры фильма ужасов 28-летняя звезда выбрала корсетные черные платья Dolce&Gabbana, которые подчеркивали изгибы ее великолепного телосложения.",
                    Date = "4 сентября 2022"
                };
                var image87 = new Image() { News = news4, Url = "./image/news4.jpg" };
                var image88 = new Image() { News = news4, Url = "./image/newsdetailed4.jpg" };
                context.Images.Add(image87);
                context.Images.Add(image88);
                context.News.Add(news4);

                var news5 = new News()
                {
                    Name = "Культовый косметический бренд Byredo выпустил модную коллекцию одежды, состоящую из одной-единственной вещи",
                    ShortDecription = "Концептуальные шведы открывают для себя новые направления в бизнесе",
                    Description = "Стало известно, что Byredo выпустил модную коллекцию одежды, состоящую из одного-единственного предмета гардероба — жакета. Сделали они это совместно с французской мануфактурой Le Laboureur. The Chore Jacket агендерный, черный, мешковатый, изготовлен из смеси хлопка и льна и подходит для любой ситуации. Ответ Byredo на вопрос из детской игры: «Если бы я был вещью в гардеробе — то какой?»",
                    Date = "27 августа 2022"
                };
                var image89 = new Image() { News = news5, Url = "./image/news5.jpg" };
                var image90 = new Image() { News = news5, Url = "./image/newsdetailed5.jpg" };
                context.Images.Add(image89);
                context.Images.Add(image90);
                context.News.Add(news5);

                var news6 = new News()
                {
                    Name = "Часы с татуировкой: новая коллаборация Hublot с тату-художником Максимом Плесчиа-Буши",
                    ShortDecription = "История Hublot X Sang Bleu продолжается тремя новыми версиями Big Bang Sang Bleu II",
                    Description = "История Hublot X Sang Bleu продолжается тремя новыми версиями Big Bang Sang Bleu II. В ознаменование седьмого года сотрудничества тату-художник Максим Плесчиа-Буши решил нанести свои работы на два культовых Hublot — золото Magic Gold и керамику. Максим Плесчиа-Буши работает решительно и без права на ошибку. Даже на устойчивых к царапинам материалах, таких как золото Magic Gold и керамика, запатентованных Hublot, или на коже его искусство оставляет неизгладимый след. Он использует трехмерную геометрию, которая включает умелое использование эффектов рельефа и глубины.",
                    Date = "27 августа 2022"
                };
                var image91 = new Image() { News = news6, Url = "./image/news6.jpg" };
                var image92 = new Image() { News = news6, Url = "./image/newsdetailed6.jpg" };
                context.Images.Add(image91);
                context.Images.Add(image92);
                context.News.Add(news6);

                context.SaveChanges();
            }
        }
    }
}
