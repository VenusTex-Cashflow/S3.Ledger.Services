using Microsoft.EntityFrameworkCore.Migrations;

namespace T3.S3Ledger.Api.Data.Migrations
{
    public partial class InitializingLedgerDataFullCountryList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Code", "IDDCode", "ISOCode3", "Name" },
                values: new object[,]
                {
                    { 1, "AF", 93, "AFG", "Afghanistan" },
                    { 152, "NC", 687, "NCL", "New Caledonia" },
                    { 153, "NZ", 64, "NZL", "New Zealand" },
                    { 154, "NI", 505, "NIC", "Nicaragua" },
                    { 155, "NE", 227, "NER", "Niger" },
                    { 156, "NG", 234, "NGA", "Nigeria" },
                    { 157, "NU", 683, "NIU", "Niue" },
                    { 158, "NF", 672, "NFK", "Norfolk Island" },
                    { 159, "MP", 1670, "MNP", "Northern Mariana Islands" },
                    { 160, "NO", 47, "NOR", "Norway" },
                    { 161, "OM", 968, "OMN", "Oman" },
                    { 162, "PK", 92, "PAK", "Pakistan" },
                    { 163, "PW", 680, "PLW", "Palau" },
                    { 151, "AN", 599, "ANT", "Netherlands Antilles" },
                    { 164, "PS", null, "PLT", "OCCUPIED Palestinian Territory " },
                    { 166, "PG", 675, "PNG", "Papua New Guinea" },
                    { 167, "PY", 595, "PRY", "Paraguay" },
                    { 168, "PE", 51, "PER", "Peru" },
                    { 169, "PH", 63, "PHL", "Philippines" },
                    { 170, "PN", 0, "PCN", "Pitcairn" },
                    { 171, "PL", 48, "POL", "Poland" },
                    { 172, "PT", 351, "PRT", "Portugal" },
                    { 173, "PR", 1787, "PRI", "Puerto Rico" },
                    { 174, "QA", 974, "QAT", "Qatar" },
                    { 175, "RE", 262, "REU", "Reunion" },
                    { 176, "RO", 40, "ROM", "Romania" },
                    { 177, "RU", 70, "RUS", "Russian Federation" },
                    { 165, "PA", 507, "PAN", "Panama" },
                    { 178, "RW", 250, "RWA", "Rwanda" },
                    { 150, "NL", 31, "NLD", "Netherlands" },
                    { 148, "NR", 674, "NRU", "Nauru" },
                    { 122, "LI", 423, "LIE", "Liechtenstein" },
                    { 123, "LT", 370, "LTU", "Lithuania" },
                    { 124, "LU", 352, "LUX", "Luxembourg" },
                    { 125, "MO", 853, "MAC", "Macao" },
                    { 126, "MK", null, "MKD", "THE FORMER YUGOSLAV REPUBLIC OF" },
                    { 127, "MG", 261, "MDG", "Madagascar" },
                    { 128, "MW", 265, "MWI", "Malawi" },
                    { 129, "MY", 60, "MYS", "Malaysia" },
                    { 130, "MV", 960, "MDV", "Maldives" },
                    { 131, "ML", 223, "MLI", "Mali" },
                    { 132, "MT", 356, "MLT", "Malta" },
                    { 133, "MH", 692, "MHL", "Marshall Islands" },
                    { 149, "NP", 977, "NPL", "Nepal" },
                    { 134, "MQ", 596, "MTQ", "Martinique" },
                    { 136, "MU", 230, "MUS", "Mauritius" },
                    { 137, "YT", 269, null, "Mayotte" },
                    { 138, "MX", 52, "MEX", "Mexico" },
                    { 139, "FM", null, "FSM", "Micronesia" },
                    { 140, "MD", null, "MDA", "Moldova" },
                    { 141, "MC", 377, "MCO", "Monaco" },
                    { 142, "MN", 976, "MNG", "Mongolia" },
                    { 143, "MS", 1664, "MSR", "Montserrat" },
                    { 144, "MA", 212, "MAR", "Morocco" },
                    { 145, "MZ", 258, "MOZ", "Mozambique" },
                    { 146, "MM", 95, "MMR", "Myanmar" },
                    { 147, "NA", 264, "NAM", "Namibia" },
                    { 135, "MR", 222, "MRT", "Mauritania" },
                    { 121, "LY", 218, "LBY", "Libyan Arab Jamahiriya" },
                    { 179, "SH", 290, "SHN", "Saint Helena" },
                    { 181, "LC", 1758, "LCA", "Saint Lucia" },
                    { 212, "TL", 670, null, "Timor-Leste" },
                    { 213, "TG", 228, "TGO", "Togo" },
                    { 214, "TK", 690, "TKL", "Tokelau" },
                    { 215, "TO", 676, "TON", "Tonga" },
                    { 216, "TT", 1868, "TTO", "Trinidad and Tobago" },
                    { 217, "TN", 216, "TUN", "Tunisia" },
                    { 218, "TR", 90, "TUR", "Turkey" },
                    { 219, "TM", 7370, "TKM", "Turkmenistan" },
                    { 220, "TC", 1649, "TCA", "Turks and Caicos Islands" },
                    { 221, "TV", 688, "TUV", "Tuvalu" },
                    { 222, "UG", 256, "UGA", "Uganda" },
                    { 223, "UA", 380, "UKR", "Ukraine" },
                    { 211, "TH", 66, "THA", "Thailand" },
                    { 224, "AE", 971, "ARE", "United Arab Emirates" },
                    { 226, "US", 1, "USA", "United States" },
                    { 227, "UM", null, null, "United States Minor Outlying Islands" },
                    { 228, "UY", 598, "URY", "Uruguay" },
                    { 229, "UZ", 998, "UZB", "Uzbekistan" },
                    { 230, "VU", 678, "VUT", "Vanuatu" },
                    { 231, "VE", 58, "VEN", "Venezuela" },
                    { 232, "VN", 84, "VNM", "Viet Nam" },
                    { 233, "VG", null, "VRI", "Virgin Islands" },
                    { 234, "VI", 1111, "VIR", "U.S.Virgin Islands" },
                    { 235, "WF", 681, "WLF", "Wallis and Futuna" },
                    { 236, "EH", 212, "ESH", "Western Sahara" },
                    { 237, "YE", 967, "YEM", "Yemen" },
                    { 225, "GB", 44, "GBR", "United Kingdom" },
                    { 180, "KN", 1869, "KNA", "Saint Kitts and Nevis" },
                    { 210, "TZ", null, "TZA", "UNITED REPUBLIC OF" },
                    { 208, "TW", null, "TWN", "PROVINCE OF CHINA TAI" },
                    { 182, "PM", 508, "SPM", "Saint Pierre and Miquelon" },
                    { 183, "VC", 1784, "VCT", "Saint Vincent and the Grenadines" },
                    { 184, "WS", 684, "WSM", "Samoa" },
                    { 185, "SM", 378, "SMR", "San Marino" },
                    { 186, "ST", 239, "STP", "Sao Tome and Principe" },
                    { 187, "SA", 966, "SAU", "Saudi Arabia" },
                    { 188, "SN", 221, "SEN", "Senegal" },
                    { 189, "CS", 381, null, "Serbia and Montenegro" },
                    { 190, "SC", 248, "SYC", "Seychelles" },
                    { 191, "SL", 232, "SLE", "Sierra Leone" },
                    { 192, "SG", 65, "SGP", "Singapore" },
                    { 193, "SK", 421, "SVK", "Slovakia" },
                    { 209, "TJ", 992, "TJK", "Tajikistan" },
                    { 194, "SI", 386, "SVN", "Slovenia" },
                    { 196, "SO", 252, "SOM", "Somalia" },
                    { 197, "ZA", 27, "ZAF", "South Africa" },
                    { 198, "GS", 0, null, "South Georgia and the South Sandwich Islands" },
                    { 199, "ES", 34, "ESP", "Spain" },
                    { 200, "LK", 94, "LKA", "Sri Lanka" },
                    { 201, "SD", 249, "SDN", "Sudan" },
                    { 202, "SR", 597, "SUR", "Suriname" },
                    { 203, "SJ", 47, "SJM", "Svalbard and Jan Mayen" },
                    { 204, "SZ", 268, "SWZ", "Swaziland" },
                    { 205, "SE", 46, "SWE", "Sweden" },
                    { 206, "CH", 41, "CHE", "Switzerland" },
                    { 207, "SY", 963, "SYR", "Syrian Arab Republic" },
                    { 195, "SB", 677, "SLB", "Solomon Islands" },
                    { 238, "ZM", 260, "ZMB", "Zambia" },
                    { 120, "LR", 231, "LBR", "Liberia" },
                    { 118, "LB", 961, "LBN", "Lebanon" },
                    { 32, "BN", 673, "BRN", "Brunei Darussalam" },
                    { 33, "BG", 359, "BGR", "Bulgaria" },
                    { 34, "BF", 226, "BFA", "Burkina Faso" },
                    { 35, "BI", 257, "BDI", "Burundi" },
                    { 36, "KH", 855, "KHM", "Cambodia" },
                    { 37, "CM", 237, "CMR", "Cameroon" },
                    { 38, "CA", 1, "CAN", "Canada" },
                    { 39, "CV", 238, "CPV", "Cape Verde" },
                    { 40, "KY", 1345, "CYM", "Cayman Islands" },
                    { 41, "CF", 236, "CAF", "Central African Republic" },
                    { 42, "TD", 235, "TCD", "Chad" },
                    { 43, "CL", 56, "CHL", "Chile" },
                    { 31, "IO", 246, null, "British Indian Ocean Territory" },
                    { 44, "CN", 86, "CHN", "China" },
                    { 46, "CC", 672, null, "Cocos Keeling Islands" },
                    { 47, "CO", 57, "COL", "Colombia" },
                    { 48, "KM", 269, "COM", "Comoros" },
                    { 49, "CG", 242, "COG", "Congo" },
                    { 50, "CD", null, "COD", "THE DEMOCRATIC REPUBLIC OF THE CONGO" },
                    { 51, "CK", 682, "COK", "Cook Islands" },
                    { 52, "CR", 506, "CRI", "Costa Rica" },
                    { 53, "CI", 225, "CIV", "Cote D'Ivoire" },
                    { 54, "HR", 385, "HRV", "Croatia" },
                    { 55, "CU", 53, "CUB", "Cuba" },
                    { 56, "CY", 357, "CYP", "Cyprus" },
                    { 57, "CZ", 420, "CZE", "Czech Republic" },
                    { 45, "CX", 61, null, "Christmas Island" },
                    { 58, "DK", 45, "DNK", "Denmark" },
                    { 30, "BR", 55, "BRA", "Brazil" },
                    { 28, "BW", 267, "BWA", "Botswana" },
                    { 2, "AL", 355, "ALB", "Albania" },
                    { 3, "DZ", 213, "DZA", "Algeria" },
                    { 4, "AS", 1684, "ASM", "American Samoa" },
                    { 5, "AD", 376, "AND", "Andorra" },
                    { 6, "AO", 244, "AGO", "Angola" },
                    { 7, "AI", 1264, "AIA", "Anguilla" },
                    { 8, "AQ", 0, null, "Antarctica" },
                    { 9, "AG", 1268, "ATG", "Antigua and Barbuda" },
                    { 10, "AR", 54, "ARG", "Argentina" },
                    { 11, "AM", 374, "ARM", "Armenia" },
                    { 12, "AW", 297, "ABW", "Aruba" },
                    { 13, "AU", 61, "AUS", "Australia" },
                    { 29, "BV", 0, null, "Bouvet Island" },
                    { 14, "AT", 43, "AUT", "Austria" },
                    { 16, "BS", 1242, "BHS", "Bahamas" },
                    { 17, "BH", 973, "BHR", "Bahrain" },
                    { 18, "BD", 880, "BGD", "Bangladesh" },
                    { 19, "BB", 1246, "BRB", "Barbados" },
                    { 20, "BY", 375, "BLR", "Belarus" },
                    { 21, "BE", 32, "BEL", "Belgium" },
                    { 22, "BZ", 501, "BLZ", "Belize" },
                    { 23, "BJ", 229, "BEN", "Benin" },
                    { 24, "BM", 1441, "BMU", "Bermuda" },
                    { 25, "BT", 975, "BTN", "Bhutan" },
                    { 26, "BO", 591, "BOL", "Bolivia" },
                    { 27, "BA", 387, "BIH", "Bosnia and Herzegovina" },
                    { 15, "AZ", 994, "AZE", "Azerbaijan" },
                    { 119, "LS", 266, "LSO", "Lesotho" },
                    { 59, "DJ", 253, "DJI", "Djibouti" },
                    { 61, "DO", 1809, "DOM", "Dominican Republic" },
                    { 92, "HT", 509, "HTI", "Haiti" },
                    { 93, "HM", 0, null, "Heard Island and Mcdonald Islands" },
                    { 94, "VA", 39, "VAT", "Holy See Vatican City State" },
                    { 95, "HN", 504, "HND", "Honduras" },
                    { 96, "HK", 852, "HKG", "Hong Kong" },
                    { 97, "HU", 36, "HUN", "Hungary" },
                    { 98, "IS", 354, "ISL", "Iceland" },
                    { 99, "IN", 91, "IND", "India" },
                    { 100, "ID", 62, "IDN", "Indonesia" },
                    { 101, "IR", null, "IRN", "ISLAMIC REPUBLIC OF" },
                    { 102, "IQ", 964, "IRQ", "Iraq" },
                    { 103, "IE", 353, "IRL", "Ireland" },
                    { 91, "GY", 592, "GUY", "Guyana" },
                    { 104, "IL", 972, "ISR", "Israel" },
                    { 106, "JM", 1876, "JAM", "Jamaica" },
                    { 107, "JP", 81, "JPN", "Japan" },
                    { 108, "JO", 962, "JOR", "Jordan" },
                    { 109, "KZ", 7, "KAZ", "Kazakhstan" },
                    { 110, "KE", 254, "KEN", "Kenya" },
                    { 111, "KI", 686, "KIR", "Kiribati" },
                    { 112, "KP", null, "KOR", "DEMOCRATIC PEOPLE'S REPUBLIC OF" },
                    { 113, "KR", null, "KOR", "REPUBLIC OF KOREA" },
                    { 114, "KW", 965, "KWT", "Kuwait" },
                    { 115, "KG", 996, "KGZ", "Kyrgyzstan" },
                    { 116, "LA", 856, "LAO", "Lao People's Democratic Republic" },
                    { 117, "LV", 371, "LVA", "Latvia" },
                    { 105, "IT", 39, "ITA", "Italy" },
                    { 60, "DM", 1767, "DMA", "Dominica" },
                    { 90, "GW", 245, "GNB", "Guinea-Bissau" },
                    { 88, "GT", 502, "GTM", "Guatemala" },
                    { 62, "EC", 593, "ECU", "Ecuador" },
                    { 63, "EG", 20, "EGY", "Egypt" },
                    { 64, "SV", 503, "SLV", "El Salvador" },
                    { 65, "GQ", 240, "GNQ", "Equatorial Guinea" },
                    { 66, "ER", 291, "ERI", "Eritrea" },
                    { 67, "EE", 372, "EST", "Estonia" },
                    { 68, "ET", 251, "ETH", "Ethiopia" },
                    { 69, "FK", 500, "FLK", "Falkland Islands Malvinas" },
                    { 70, "FO", 298, "FRO", "Faroe Islands" },
                    { 71, "FJ", 679, "FJI", "Fiji" },
                    { 72, "FI", 358, "FIN", "Finland" },
                    { 73, "FR", 33, "FRA", "France" },
                    { 89, "GN", 224, "GIN", "Guinea" },
                    { 74, "GF", 594, "GUF", "French Guiana" },
                    { 76, "TF", 0, null, "French Southern Territories" },
                    { 77, "GA", 241, "GAB", "Gabon" },
                    { 78, "GM", 220, "GMB", "Gambia" },
                    { 79, "GE", 995, "GEO", "Georgia" },
                    { 80, "DE", 49, "DEU", "Germany" },
                    { 81, "GH", 233, "GHA", "Ghana" },
                    { 82, "GI", 350, "GIB", "Gibraltar" },
                    { 83, "GR", 30, "GRC", "Greece" },
                    { 84, "GL", 299, "GRL", "Greenland" },
                    { 85, "GD", 1473, "GRD", "Grenada" },
                    { 86, "GP", 590, "GLP", "Guadeloupe" },
                    { 87, "GU", 1671, "GUM", "Guam" },
                    { 75, "PF", 689, "PYF", "French Polynesia" },
                    { 239, "ZW", 263, "ZWE", "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "Address1", "Address2", "Address3", "City", "CountryId", "Name", "OrganizationCode", "PrimaryInvestor" },
                values: new object[] { 1, null, null, null, null, 200, "TrueThink", "T3", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}
