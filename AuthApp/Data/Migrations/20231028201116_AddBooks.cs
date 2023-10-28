using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Isbn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Isbn", "Title", "Year" },
                values: new object[,]
                {
                    { 1L, "Emmalee West", "cytinbfvyg", "functionalities", 1991 },
                    { 2L, "Araceli Bode", "4slj4n7vae", "Naira", 2010 },
                    { 3L, "Josh Walsh", "j87comuj5x", "connect", 1963 },
                    { 4L, "Pat Prohaska", "brvfvasc6b", "Chad", 1915 },
                    { 5L, "Keira Waelchi", "c0xih8ega8", "Sleek Wooden Fish", 1954 },
                    { 6L, "Brian Baumbach", "3k24v2mnqw", "Home Loan Account", 1902 },
                    { 7L, "Henri Jacobi", "cl55u7ujhz", "Awesome Rubber Gloves", 1974 },
                    { 8L, "Chad Bode", "yx1movpd7m", "Fantastic Metal Soap", 1956 },
                    { 9L, "Skylar Wintheiser", "s190zw8d8k", "fuchsia", 1948 },
                    { 10L, "Laverna Hettinger", "5fvglddroq", "Small", 1953 },
                    { 11L, "Kraig Howe", "cm3m8bgk66", "calculate", 1989 },
                    { 12L, "Ambrose Gulgowski", "sorug0beal", "South Dakota", 1953 },
                    { 13L, "Duane Lockman", "4ltu8szec1", "methodical", 1987 },
                    { 14L, "Dorris Stracke", "tjpdyqzs4d", "SMTP", 1903 },
                    { 15L, "Amanda Schroeder", "1uan24qzti", "indigo", 1998 },
                    { 16L, "Pierce Roberts", "5n4frvk8bs", "hardware", 1915 },
                    { 17L, "Jayda Doyle", "k7cj0uk17q", "wireless", 1909 },
                    { 18L, "Rowland Corwin", "fkzd7d2cax", "Turnpike", 1958 },
                    { 19L, "Roma Welch", "b2hmylyvsw", "Personal Loan Account", 1972 },
                    { 20L, "Maynard Pollich", "and6djta9t", "Personal Loan Account", 1959 },
                    { 21L, "Leonie Lind", "8l69e03awj", "backing up", 1958 },
                    { 22L, "Jerrod Mraz", "r5nlmt8she", "Danish Krone", 1962 },
                    { 23L, "Paula Koelpin", "qw98nzfnao", "override", 1926 },
                    { 24L, "Lizeth Torp", "ulsn2b7gzp", "grow", 2021 },
                    { 25L, "Sasha Turcotte", "8vhfskfyum", "wireless", 1942 },
                    { 26L, "Sylvia Johnson", "fr5ljwzkq4", "Guatemala", 1966 },
                    { 27L, "Jude Pacocha", "5psdgcv1tb", "Glens", 1953 },
                    { 28L, "Agustin Rath", "tukka8n4bz", "Personal Loan Account", 1929 },
                    { 29L, "Elody Gerhold", "54f5gmqyg2", "pricing structure", 1967 },
                    { 30L, "Earnestine Brakus", "a1j0bpvq8g", "array", 1962 },
                    { 31L, "Grady Emmerich", "14qk6b6sj2", "Locks", 1910 },
                    { 32L, "Jennings Reynolds", "hbu8p7rqzk", "RAM", 1932 },
                    { 33L, "Meredith Willms", "2ak81f0r4s", "eyeballs", 1910 },
                    { 34L, "Ursula Ferry", "tr8iy6q7o0", "Adaptive", 1935 },
                    { 35L, "Adalberto Turner", "wz3l0sbvgb", "deliverables", 1960 },
                    { 36L, "Holly Mraz", "zqsqqh5orr", "Oregon", 1938 },
                    { 37L, "Albina Gerlach", "r7w35exfiw", "Unbranded Concrete Fish", 1995 },
                    { 38L, "Lindsey Anderson", "s20jmz9fqa", "turquoise", 1940 },
                    { 39L, "Nasir Kassulke", "mqa8sijitb", "wireless", 2004 },
                    { 40L, "Kolby Hudson", "ha5a9t76e9", "core", 1961 },
                    { 41L, "Queenie Schumm", "l8o391w8th", "back-end", 1930 },
                    { 42L, "Cortney Rowe", "o0ucs1negl", "Georgia", 1953 },
                    { 43L, "Wallace Haag", "pdp0qmm5bc", "Taiwan", 1971 },
                    { 44L, "Dorian Adams", "znkgys0ryt", "Incredible Soft Chair", 1927 },
                    { 45L, "Jordon Batz", "9irut6h42v", "Cambridgeshire", 1965 },
                    { 46L, "Eric McLaughlin", "fbfj7eurlp", "Industrial", 1929 },
                    { 47L, "Green Pacocha", "gtjst16gth", "transmit", 1963 },
                    { 48L, "Henderson Schimmel", "ssm8s5eytv", "Montserrat", 1984 },
                    { 49L, "Ulises Ratke", "cn726o6ik9", "Music", 2008 },
                    { 50L, "May Swift", "8csxf5jmi1", "Causeway", 2006 },
                    { 51L, "Brannon Bailey", "wbvs6uecm4", "capacitor", 1976 },
                    { 52L, "Johnpaul Gerlach", "tw4zgnh6ik", "Metal", 1998 },
                    { 53L, "Tyrese Fisher", "djdjq9j0uz", "Handcrafted Steel Gloves", 1921 },
                    { 54L, "Alexandro Stracke", "398ylxoce5", "neural", 1945 },
                    { 55L, "Ramona Reinger", "ca6dq54p3m", "Implemented", 1972 },
                    { 56L, "Marianne Hackett", "dpjxxesdca", "Orchestrator", 1986 },
                    { 57L, "Anastasia Crooks", "73nvmfapyk", "Tasty Cotton Pants", 1918 },
                    { 58L, "Violette Bernhard", "o3roofvbkx", "access", 2002 },
                    { 59L, "Wilbert Dach", "aqkfri1fr9", "Small", 1928 },
                    { 60L, "Rory Murphy", "1bcmhvnodq", "Virtual", 1941 },
                    { 61L, "Verda Schinner", "caqs9fql7k", "primary", 1980 },
                    { 62L, "Gwen Kirlin", "7whxviqdhb", "invoice", 1978 },
                    { 63L, "Horacio Ratke", "xgywyh6k7a", "Clothing", 1990 },
                    { 64L, "Roderick Dibbert", "naxifb52al", "Steel", 2010 },
                    { 65L, "Litzy Hudson", "jvrup71hiq", "Networked", 1989 },
                    { 66L, "Korbin Russel", "lbn4zr96ze", "International", 1996 },
                    { 67L, "Emelie Beatty", "8oytrud74z", "infomediaries", 1976 },
                    { 68L, "Pascale Purdy", "efhizlldnm", "redundant", 1933 },
                    { 69L, "Itzel Walsh", "td6gh1ywtx", "Syrian Pound", 1928 },
                    { 70L, "Brooklyn Hessel", "yueazcw5bg", "Sleek", 1978 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
