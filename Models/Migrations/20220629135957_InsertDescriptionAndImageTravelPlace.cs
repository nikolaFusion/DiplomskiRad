using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class InsertDescriptionAndImageTravelPlace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TravelPlaces",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "TravelPlaces",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://www.infokop.net/mambots/content/multithumb/images/b.800.600.0.1.stories.vesti.2019.zima.ski-opening-2018.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://www.ceeh.es/wp-content/uploads/2021/06/b.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://www.telegraph.co.uk/content/dam/Travel/Destinations/Europe/Iceland/Reykjavik/reykjavik-guide-lead-image-48-hours-xlarge.jpg?imwidth=640" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://cdn.ceoworld.biz/wp-content/uploads/2022/04/Benefits-of-Holding-a-Canadia-Passport.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://cdn.kimkim.com/files/a/content_articles/featured_photos/9e76018b4dbc115cd4f8a51f0a49a9948a28cb74/big-2d3b3fc973f25a6a9252308e46b35546.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://i.pinimg.com/736x/c2/b8/85/c2b88548dd9f646948c27caa3131ea6e.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://travel.mqcdn.com/mapquest/travel/wp-content/uploads/2020/06/GettyImages-676934538-e1592461667985-835x480.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://www.traveller.com.au/content/dam/images/1/0/7/5/k/n/image.related.articleLeadwide.620x349.zsbg7.png/1425452937659.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://media.cntraveler.com/photos/5b742b0cde8e29470d34f562/16:9/w_2560,c_limit/Cape-of-Good-Hope_GettyImages-962634118.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://eeradicalization.com/wp-content/uploads/2020/03/ccimage-shutterstock_1075717346.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "http://thehumanist.com/wp-content/uploads/2015/03/statue.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSLN31eVZKvcBDST2b-ehzDBBqI2X38aN_bRQTIRnY_dOVw7_ycyKLxTCBLywFRnJ4VzTs&usqp=CAU" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "http://chinaflowers.net/blog/wp-content/uploads/2011/11/beijing_1.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://www.planetware.com/wpimages/2019/08/thailand-in-pictures-most-beautiful-places-bangkok-riverfront.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://ssl.tzoo-img.com/images/blog/2019/2/8/ssimg_210.jpg?width=412&spr=3" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://www.andbeyond.com/wp-content/uploads/sites/5/Herd-of-Elephants-walking-while-guests-cross-channel-on-a-Safari-Game-Drive-in-Botswana.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 17,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSEaXji0VkVk3EnKP7UPrS6ZY-FEQOk9W_5Le4VrSEK07Sy9BJB2-v4u1L9Xsq3blTDnUo&usqp=CAU" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 18,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://m.psecn.photoshelter.com/img-get/I0000KM3Tgz.EL9c/s/900/600/bullfighting-corrida-spain-40.jpg" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 19,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRg9Bh1GEsvpvMoAKQZMtxLI8v16ormJMHb8z6usd-oj0PPXq5BLCZkKq2qT_YTavgNfd4&usqp=CAU" });

            migrationBuilder.UpdateData(
                table: "TravelPlaces",
                keyColumn: "TravelPlaceID",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "", "https://media.istockphoto.com/photos/little-girl-hugs-koala-picture-id626145812?k=20&m=626145812&s=612x612&w=0&h=X11Nn3LhtqlVj_fU0YvnWY_NrcrKF--P34k_nZNHzZA=" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TravelPlaces");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "TravelPlaces");
        }
    }
}
