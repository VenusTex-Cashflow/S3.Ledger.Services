﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using T3.S3Ledger.Api.Data.Entities;

namespace T3.S3Ledger.Api.Data.Configurations
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public override void Map(EntityTypeBuilder<Country> modelBuilder)
        {
            modelBuilder
                .ToTable("Country")
                .HasKey(c => c.Id);

            modelBuilder
                .HasData(
                    new Country { Id = 1, Name = "Afghanistan", Code = "AF", IDDCode = 93, ISOCode3 = "AFG" },
                    new Country { Id = 2, Name = "Albania", Code = "AL", IDDCode = 355, ISOCode3 = "ALB" },
                    new Country { Id = 3, Name = "Algeria", Code = "DZ", IDDCode = 213, ISOCode3 = "DZA" },
                    new Country { Id = 4, Name = "American Samoa", Code = "AS", IDDCode = 1684, ISOCode3 = "ASM" },
                    new Country { Id = 5, Name = "Andorra", Code = "AD", IDDCode = 376, ISOCode3 = "AND" },
                    new Country { Id = 6, Name = "Angola", Code = "AO", IDDCode = 244, ISOCode3 = "AGO" },
                    new Country { Id = 7, Name = "Anguilla", Code = "AI", IDDCode = 1264, ISOCode3 = "AIA" },
                    new Country { Id = 8, Name = "Antarctica", Code = "AQ", IDDCode = 0, ISOCode3 = null },
                    new Country { Id = 9, Name = "Antigua and Barbuda", Code = "AG", IDDCode = 1268, ISOCode3 = "ATG" },
                    new Country { Id = 10, Name = "Argentina", Code = "AR", IDDCode = 54, ISOCode3 = "ARG" },
                    new Country { Id = 11, Name = "Armenia", Code = "AM", IDDCode = 374, ISOCode3 = "ARM" },
                    new Country { Id = 12, Name = "Aruba", Code = "AW", IDDCode = 297, ISOCode3 = "ABW" },
                    new Country { Id = 13, Name = "Australia", Code = "AU", IDDCode = 61, ISOCode3 = "AUS" },
                    new Country { Id = 14, Name = "Austria", Code = "AT", IDDCode = 43, ISOCode3 = "AUT" },
                    new Country { Id = 15, Name = "Azerbaijan", Code = "AZ", IDDCode = 994, ISOCode3 = "AZE" },
                    new Country { Id = 16, Name = "Bahamas", Code = "BS", IDDCode = 1242, ISOCode3 = "BHS" },
                    new Country { Id = 17, Name = "Bahrain", Code = "BH", IDDCode = 973, ISOCode3 = "BHR" },
                    new Country { Id = 18, Name = "Bangladesh", Code = "BD", IDDCode = 880, ISOCode3 = "BGD" },
                    new Country { Id = 19, Name = "Barbados", Code = "BB", IDDCode = 1246, ISOCode3 = "BRB" },
                    new Country { Id = 20, Name = "Belarus", Code = "BY", IDDCode = 375, ISOCode3 = "BLR" },
                    new Country { Id = 21, Name = "Belgium", Code = "BE", IDDCode = 32, ISOCode3 = "BEL" },
                    new Country { Id = 22, Name = "Belize", Code = "BZ", IDDCode = 501, ISOCode3 = "BLZ" },
                    new Country { Id = 23, Name = "Benin", Code = "BJ", IDDCode = 229, ISOCode3 = "BEN" },
                    new Country { Id = 24, Name = "Bermuda", Code = "BM", IDDCode = 1441, ISOCode3 = "BMU" },
                    new Country { Id = 25, Name = "Bhutan", Code = "BT", IDDCode = 975, ISOCode3 = "BTN" },
                    new Country { Id = 26, Name = "Bolivia", Code = "BO", IDDCode = 591, ISOCode3 = "BOL" },
                    new Country { Id = 27, Name = "Bosnia and Herzegovina", Code = "BA", IDDCode = 387, ISOCode3 = "BIH" },
                    new Country { Id = 28, Name = "Botswana", Code = "BW", IDDCode = 267, ISOCode3 = "BWA" },
                    new Country { Id = 29, Name = "Bouvet Island", Code = "BV", IDDCode = 0, ISOCode3 = null },
                    new Country { Id = 30, Name = "Brazil", Code = "BR", IDDCode = 55, ISOCode3 = "BRA" },
                    new Country { Id = 31, Name = "British Indian Ocean Territory", Code = "IO", IDDCode = 246, ISOCode3 = null },
                    new Country { Id = 32, Name = "Brunei Darussalam", Code = "BN", IDDCode = 673, ISOCode3 = "BRN" },
                    new Country { Id = 33, Name = "Bulgaria", Code = "BG", IDDCode = 359, ISOCode3 = "BGR" },
                    new Country { Id = 34, Name = "Burkina Faso", Code = "BF", IDDCode = 226, ISOCode3 = "BFA" },
                    new Country { Id = 35, Name = "Burundi", Code = "BI", IDDCode = 257, ISOCode3 = "BDI" },
                    new Country { Id = 36, Name = "Cambodia", Code = "KH", IDDCode = 855, ISOCode3 = "KHM" },
                    new Country { Id = 37, Name = "Cameroon", Code = "CM", IDDCode = 237, ISOCode3 = "CMR" },
                    new Country { Id = 38, Name = "Canada", Code = "CA", IDDCode = 1, ISOCode3 = "CAN" },
                    new Country { Id = 39, Name = "Cape Verde", Code = "CV", IDDCode = 238, ISOCode3 = "CPV" },
                    new Country { Id = 40, Name = "Cayman Islands", Code = "KY", IDDCode = 1345, ISOCode3 = "CYM" },
                    new Country { Id = 41, Name = "Central African Republic", Code = "CF", IDDCode = 236, ISOCode3 = "CAF" },
                    new Country { Id = 42, Name = "Chad", Code = "TD", IDDCode = 235, ISOCode3 = "TCD" },
                    new Country { Id = 43, Name = "Chile", Code = "CL", IDDCode = 56, ISOCode3 = "CHL" },
                    new Country { Id = 44, Name = "China", Code = "CN", IDDCode = 86, ISOCode3 = "CHN" },
                    new Country { Id = 45, Name = "Christmas Island", Code = "CX", IDDCode = 61, ISOCode3 = null },
                    new Country { Id = 46, Name = "Cocos Keeling Islands", Code = "CC", IDDCode = 672, ISOCode3 = null },
                    new Country { Id = 47, Name = "Colombia", Code = "CO", IDDCode = 57, ISOCode3 = "COL" },
                    new Country { Id = 48, Name = "Comoros", Code = "KM", IDDCode = 269, ISOCode3 = "COM" },
                    new Country { Id = 49, Name = "Congo", Code = "CG", IDDCode = 242, ISOCode3 = "COG" },
                    new Country { Id = 50, Name = "THE DEMOCRATIC REPUBLIC OF THE CONGO", Code = "CD", IDDCode = null, ISOCode3 = "COD" },
                    new Country { Id = 51, Name = "Cook Islands", Code = "CK", IDDCode = 682, ISOCode3 = "COK" },
                    new Country { Id = 52, Name = "Costa Rica", Code = "CR", IDDCode = 506, ISOCode3 = "CRI" },
                    new Country { Id = 53, Name = "Cote D'Ivoire", Code = "CI", IDDCode = 225, ISOCode3 = "CIV" },
                    new Country { Id = 54, Name = "Croatia", Code = "HR", IDDCode = 385, ISOCode3 = "HRV" },
                    new Country { Id = 55, Name = "Cuba", Code = "CU", IDDCode = 53, ISOCode3 = "CUB" },
                    new Country { Id = 56, Name = "Cyprus", Code = "CY", IDDCode = 357, ISOCode3 = "CYP" },
                    new Country { Id = 57, Name = "Czech Republic", Code = "CZ", IDDCode = 420, ISOCode3 = "CZE" },
                    new Country { Id = 58, Name = "Denmark", Code = "DK", IDDCode = 45, ISOCode3 = "DNK" },
                    new Country { Id = 59, Name = "Djibouti", Code = "DJ", IDDCode = 253, ISOCode3 = "DJI" },
                    new Country { Id = 60, Name = "Dominica", Code = "DM", IDDCode = 1767, ISOCode3 = "DMA" },
                    new Country { Id = 61, Name = "Dominican Republic", Code = "DO", IDDCode = 1809, ISOCode3 = "DOM" },
                    new Country { Id = 62, Name = "Ecuador", Code = "EC", IDDCode = 593, ISOCode3 = "ECU" },
                    new Country { Id = 63, Name = "Egypt", Code = "EG", IDDCode = 20, ISOCode3 = "EGY" },
                    new Country { Id = 64, Name = "El Salvador", Code = "SV", IDDCode = 503, ISOCode3 = "SLV" },
                    new Country { Id = 65, Name = "Equatorial Guinea", Code = "GQ", IDDCode = 240, ISOCode3 = "GNQ" },
                    new Country { Id = 66, Name = "Eritrea", Code = "ER", IDDCode = 291, ISOCode3 = "ERI" },
                    new Country { Id = 67, Name = "Estonia", Code = "EE", IDDCode = 372, ISOCode3 = "EST" },
                    new Country { Id = 68, Name = "Ethiopia", Code = "ET", IDDCode = 251, ISOCode3 = "ETH" },
                    new Country { Id = 69, Name = "Falkland Islands Malvinas", Code = "FK", IDDCode = 500, ISOCode3 = "FLK" },
                    new Country { Id = 70, Name = "Faroe Islands", Code = "FO", IDDCode = 298, ISOCode3 = "FRO" },
                    new Country { Id = 71, Name = "Fiji", Code = "FJ", IDDCode = 679, ISOCode3 = "FJI" },
                    new Country { Id = 72, Name = "Finland", Code = "FI", IDDCode = 358, ISOCode3 = "FIN" },
                    new Country { Id = 73, Name = "France", Code = "FR", IDDCode = 33, ISOCode3 = "FRA" },
                    new Country { Id = 74, Name = "French Guiana", Code = "GF", IDDCode = 594, ISOCode3 = "GUF" },
                    new Country { Id = 75, Name = "French Polynesia", Code = "PF", IDDCode = 689, ISOCode3 = "PYF" },
                    new Country { Id = 76, Name = "French Southern Territories", Code = "TF", IDDCode = 0, ISOCode3 = null },
                    new Country { Id = 77, Name = "Gabon", Code = "GA", IDDCode = 241, ISOCode3 = "GAB" },
                    new Country { Id = 78, Name = "Gambia", Code = "GM", IDDCode = 220, ISOCode3 = "GMB" },
                    new Country { Id = 79, Name = "Georgia", Code = "GE", IDDCode = 995, ISOCode3 = "GEO" },
                    new Country { Id = 80, Name = "Germany", Code = "DE", IDDCode = 49, ISOCode3 = "DEU" },
                    new Country { Id = 81, Name = "Ghana", Code = "GH", IDDCode = 233, ISOCode3 = "GHA" },
                    new Country { Id = 82, Name = "Gibraltar", Code = "GI", IDDCode = 350, ISOCode3 = "GIB" },
                    new Country { Id = 83, Name = "Greece", Code = "GR", IDDCode = 30, ISOCode3 = "GRC" },
                    new Country { Id = 84, Name = "Greenland", Code = "GL", IDDCode = 299, ISOCode3 = "GRL" },
                    new Country { Id = 85, Name = "Grenada", Code = "GD", IDDCode = 1473, ISOCode3 = "GRD" },
                    new Country { Id = 86, Name = "Guadeloupe", Code = "GP", IDDCode = 590, ISOCode3 = "GLP" },
                    new Country { Id = 87, Name = "Guam", Code = "GU", IDDCode = 1671, ISOCode3 = "GUM" },
                    new Country { Id = 88, Name = "Guatemala", Code = "GT", IDDCode = 502, ISOCode3 = "GTM" },
                    new Country { Id = 89, Name = "Guinea", Code = "GN", IDDCode = 224, ISOCode3 = "GIN" },
                    new Country { Id = 90, Name = "Guinea-Bissau", Code = "GW", IDDCode = 245, ISOCode3 = "GNB" },
                    new Country { Id = 91, Name = "Guyana", Code = "GY", IDDCode = 592, ISOCode3 = "GUY" },
                    new Country { Id = 92, Name = "Haiti", Code = "HT", IDDCode = 509, ISOCode3 = "HTI" },
                    new Country { Id = 93, Name = "Heard Island and Mcdonald Islands", Code = "HM", IDDCode = 0, ISOCode3 = null },
                    new Country { Id = 94, Name = "Holy See Vatican City State", Code = "VA", IDDCode = 39, ISOCode3 = "VAT" },
                    new Country { Id = 95, Name = "Honduras", Code = "HN", IDDCode = 504, ISOCode3 = "HND" },
                    new Country { Id = 96, Name = "Hong Kong", Code = "HK", IDDCode = 852, ISOCode3 = "HKG" },
                    new Country { Id = 97, Name = "Hungary", Code = "HU", IDDCode = 36, ISOCode3 = "HUN" },
                    new Country { Id = 98, Name = "Iceland", Code = "IS", IDDCode = 354, ISOCode3 = "ISL" },
                    new Country { Id = 99, Name = "India", Code = "IN", IDDCode = 91, ISOCode3 = "IND" },
                    new Country { Id = 100, Name = "Indonesia", Code = "ID", IDDCode = 62, ISOCode3 = "IDN" },
                    new Country { Id = 101, Name = "ISLAMIC REPUBLIC OF", Code = "IR", IDDCode = null, ISOCode3 = "IRN" },
                    new Country { Id = 102, Name = "Iraq", Code = "IQ", IDDCode = 964, ISOCode3 = "IRQ" },
                    new Country { Id = 103, Name = "Ireland", Code = "IE", IDDCode = 353, ISOCode3 = "IRL" },
                    new Country { Id = 104, Name = "Israel", Code = "IL", IDDCode = 972, ISOCode3 = "ISR" },
                    new Country { Id = 105, Name = "Italy", Code = "IT", IDDCode = 39, ISOCode3 = "ITA" },
                    new Country { Id = 106, Name = "Jamaica", Code = "JM", IDDCode = 1876, ISOCode3 = "JAM" },
                    new Country { Id = 107, Name = "Japan", Code = "JP", IDDCode = 81, ISOCode3 = "JPN" },
                    new Country { Id = 108, Name = "Jordan", Code = "JO", IDDCode = 962, ISOCode3 = "JOR" },
                    new Country { Id = 109, Name = "Kazakhstan", Code = "KZ", IDDCode = 7, ISOCode3 = "KAZ" },
                    new Country { Id = 110, Name = "Kenya", Code = "KE", IDDCode = 254, ISOCode3 = "KEN" },
                    new Country { Id = 111, Name = "Kiribati", Code = "KI", IDDCode = 686, ISOCode3 = "KIR" },
                    new Country { Id = 112, Name = "DEMOCRATIC PEOPLE'S REPUBLIC OF", Code = "KP", IDDCode = null, ISOCode3 = "KOR" },
                    new Country { Id = 113, Name = "REPUBLIC OF KOREA", Code = "KR", IDDCode = null, ISOCode3 = "KOR" },
                    new Country { Id = 114, Name = "Kuwait", Code = "KW", IDDCode = 965, ISOCode3 = "KWT" },
                    new Country { Id = 115, Name = "Kyrgyzstan", Code = "KG", IDDCode = 996, ISOCode3 = "KGZ" },
                    new Country { Id = 116, Name = "Lao People's Democratic Republic", Code = "LA", IDDCode = 856, ISOCode3 = "LAO" },
                    new Country { Id = 117, Name = "Latvia", Code = "LV", IDDCode = 371, ISOCode3 = "LVA" },
                    new Country { Id = 118, Name = "Lebanon", Code = "LB", IDDCode = 961, ISOCode3 = "LBN" },
                    new Country { Id = 119, Name = "Lesotho", Code = "LS", IDDCode = 266, ISOCode3 = "LSO" },
                    new Country { Id = 120, Name = "Liberia", Code = "LR", IDDCode = 231, ISOCode3 = "LBR" },
                    new Country { Id = 121, Name = "Libyan Arab Jamahiriya", Code = "LY", IDDCode = 218, ISOCode3 = "LBY" },
                    new Country { Id = 122, Name = "Liechtenstein", Code = "LI", IDDCode = 423, ISOCode3 = "LIE" },
                    new Country { Id = 123, Name = "Lithuania", Code = "LT", IDDCode = 370, ISOCode3 = "LTU" },
                    new Country { Id = 124, Name = "Luxembourg", Code = "LU", IDDCode = 352, ISOCode3 = "LUX" },
                    new Country { Id = 125, Name = "Macao", Code = "MO", IDDCode = 853, ISOCode3 = "MAC" },
                    new Country { Id = 126, Name = "THE FORMER YUGOSLAV REPUBLIC OF", Code = "MK", IDDCode = null, ISOCode3 = "MKD" },
                    new Country { Id = 127, Name = "Madagascar", Code = "MG", IDDCode = 261, ISOCode3 = "MDG" },
                    new Country { Id = 128, Name = "Malawi", Code = "MW", IDDCode = 265, ISOCode3 = "MWI" },
                    new Country { Id = 129, Name = "Malaysia", Code = "MY", IDDCode = 60, ISOCode3 = "MYS" },
                    new Country { Id = 130, Name = "Maldives", Code = "MV", IDDCode = 960, ISOCode3 = "MDV" },
                    new Country { Id = 131, Name = "Mali", Code = "ML", IDDCode = 223, ISOCode3 = "MLI" },
                    new Country { Id = 132, Name = "Malta", Code = "MT", IDDCode = 356, ISOCode3 = "MLT" },
                    new Country { Id = 133, Name = "Marshall Islands", Code = "MH", IDDCode = 692, ISOCode3 = "MHL" },
                    new Country { Id = 134, Name = "Martinique", Code = "MQ", IDDCode = 596, ISOCode3 = "MTQ" },
                    new Country { Id = 135, Name = "Mauritania", Code = "MR", IDDCode = 222, ISOCode3 = "MRT" },
                    new Country { Id = 136, Name = "Mauritius", Code = "MU", IDDCode = 230, ISOCode3 = "MUS" },
                    new Country { Id = 137, Name = "Mayotte", Code = "YT", IDDCode = 269, ISOCode3 = null },
                    new Country { Id = 138, Name = "Mexico", Code = "MX", IDDCode = 52, ISOCode3 = "MEX" },
                    new Country { Id = 139, Name = "Micronesia", Code = "FM", IDDCode = null, ISOCode3 = "FSM" },
                    new Country { Id = 140, Name = "Moldova", Code = "MD", IDDCode = null, ISOCode3 = "MDA" },
                    new Country { Id = 141, Name = "Monaco", Code = "MC", IDDCode = 377, ISOCode3 = "MCO" },
                    new Country { Id = 142, Name = "Mongolia", Code = "MN", IDDCode = 976, ISOCode3 = "MNG" },
                    new Country { Id = 143, Name = "Montserrat", Code = "MS", IDDCode = 1664, ISOCode3 = "MSR" },
                    new Country { Id = 144, Name = "Morocco", Code = "MA", IDDCode = 212, ISOCode3 = "MAR" },
                    new Country { Id = 145, Name = "Mozambique", Code = "MZ", IDDCode = 258, ISOCode3 = "MOZ" },
                    new Country { Id = 146, Name = "Myanmar", Code = "MM", IDDCode = 95, ISOCode3 = "MMR" },
                    new Country { Id = 147, Name = "Namibia", Code = "NA", IDDCode = 264, ISOCode3 = "NAM" },
                    new Country { Id = 148, Name = "Nauru", Code = "NR", IDDCode = 674, ISOCode3 = "NRU" },
                    new Country { Id = 149, Name = "Nepal", Code = "NP", IDDCode = 977, ISOCode3 = "NPL" },
                    new Country { Id = 150, Name = "Netherlands", Code = "NL", IDDCode = 31, ISOCode3 = "NLD" },
                    new Country { Id = 151, Name = "Netherlands Antilles", Code = "AN", IDDCode = 599, ISOCode3 = "ANT" },
                    new Country { Id = 152, Name = "New Caledonia", Code = "NC", IDDCode = 687, ISOCode3 = "NCL" },
                    new Country { Id = 153, Name = "New Zealand", Code = "NZ", IDDCode = 64, ISOCode3 = "NZL" },
                    new Country { Id = 154, Name = "Nicaragua", Code = "NI", IDDCode = 505, ISOCode3 = "NIC" },
                    new Country { Id = 155, Name = "Niger", Code = "NE", IDDCode = 227, ISOCode3 = "NER" },
                    new Country { Id = 156, Name = "Nigeria", Code = "NG", IDDCode = 234, ISOCode3 = "NGA" },
                    new Country { Id = 157, Name = "Niue", Code = "NU", IDDCode = 683, ISOCode3 = "NIU" },
                    new Country { Id = 158, Name = "Norfolk Island", Code = "NF", IDDCode = 672, ISOCode3 = "NFK" },
                    new Country { Id = 159, Name = "Northern Mariana Islands", Code = "MP", IDDCode = 1670, ISOCode3 = "MNP" },
                    new Country { Id = 160, Name = "Norway", Code = "NO", IDDCode = 47, ISOCode3 = "NOR" },
                    new Country { Id = 161, Name = "Oman", Code = "OM", IDDCode = 968, ISOCode3 = "OMN" },
                    new Country { Id = 162, Name = "Pakistan", Code = "PK", IDDCode = 92, ISOCode3 = "PAK" },
                    new Country { Id = 163, Name = "Palau", Code = "PW", IDDCode = 680, ISOCode3 = "PLW" },
                    new Country { Id = 164, Name = "OCCUPIED Palestinian Territory ", Code = "PS", IDDCode = null, ISOCode3 = "PLT" },
                    new Country { Id = 165, Name = "Panama", Code = "PA", IDDCode = 507, ISOCode3 = "PAN" },
                    new Country { Id = 166, Name = "Papua New Guinea", Code = "PG", IDDCode = 675, ISOCode3 = "PNG" },
                    new Country { Id = 167, Name = "Paraguay", Code = "PY", IDDCode = 595, ISOCode3 = "PRY" },
                    new Country { Id = 168, Name = "Peru", Code = "PE", IDDCode = 51, ISOCode3 = "PER" },
                    new Country { Id = 169, Name = "Philippines", Code = "PH", IDDCode = 63, ISOCode3 = "PHL" },
                    new Country { Id = 170, Name = "Pitcairn", Code = "PN", IDDCode = 0, ISOCode3 = "PCN" },
                    new Country { Id = 171, Name = "Poland", Code = "PL", IDDCode = 48, ISOCode3 = "POL" },
                    new Country { Id = 172, Name = "Portugal", Code = "PT", IDDCode = 351, ISOCode3 = "PRT" },
                    new Country { Id = 173, Name = "Puerto Rico", Code = "PR", IDDCode = 1787, ISOCode3 = "PRI" },
                    new Country { Id = 174, Name = "Qatar", Code = "QA", IDDCode = 974, ISOCode3 = "QAT" },
                    new Country { Id = 175, Name = "Reunion", Code = "RE", IDDCode = 262, ISOCode3 = "REU" },
                    new Country { Id = 176, Name = "Romania", Code = "RO", IDDCode = 40, ISOCode3 = "ROM" },
                    new Country { Id = 177, Name = "Russian Federation", Code = "RU", IDDCode = 70, ISOCode3 = "RUS" },
                    new Country { Id = 178, Name = "Rwanda", Code = "RW", IDDCode = 250, ISOCode3 = "RWA" },
                    new Country { Id = 179, Name = "Saint Helena", Code = "SH", IDDCode = 290, ISOCode3 = "SHN" },
                    new Country { Id = 180, Name = "Saint Kitts and Nevis", Code = "KN", IDDCode = 1869, ISOCode3 = "KNA" },
                    new Country { Id = 181, Name = "Saint Lucia", Code = "LC", IDDCode = 1758, ISOCode3 = "LCA" },
                    new Country { Id = 182, Name = "Saint Pierre and Miquelon", Code = "PM", IDDCode = 508, ISOCode3 = "SPM" },
                    new Country { Id = 183, Name = "Saint Vincent and the Grenadines", Code = "VC", IDDCode = 1784, ISOCode3 = "VCT" },
                    new Country { Id = 184, Name = "Samoa", Code = "WS", IDDCode = 684, ISOCode3 = "WSM" },
                    new Country { Id = 185, Name = "San Marino", Code = "SM", IDDCode = 378, ISOCode3 = "SMR" },
                    new Country { Id = 186, Name = "Sao Tome and Principe", Code = "ST", IDDCode = 239, ISOCode3 = "STP" },
                    new Country { Id = 187, Name = "Saudi Arabia", Code = "SA", IDDCode = 966, ISOCode3 = "SAU" },
                    new Country { Id = 188, Name = "Senegal", Code = "SN", IDDCode = 221, ISOCode3 = "SEN" },
                    new Country { Id = 189, Name = "Serbia and Montenegro", Code = "CS", IDDCode = 381, ISOCode3 = null },
                    new Country { Id = 190, Name = "Seychelles", Code = "SC", IDDCode = 248, ISOCode3 = "SYC" },
                    new Country { Id = 191, Name = "Sierra Leone", Code = "SL", IDDCode = 232, ISOCode3 = "SLE" },
                    new Country { Id = 192, Name = "Singapore", Code = "SG", IDDCode = 65, ISOCode3 = "SGP" },
                    new Country { Id = 193, Name = "Slovakia", Code = "SK", IDDCode = 421, ISOCode3 = "SVK" },
                    new Country { Id = 194, Name = "Slovenia", Code = "SI", IDDCode = 386, ISOCode3 = "SVN" },
                    new Country { Id = 195, Name = "Solomon Islands", Code = "SB", IDDCode = 677, ISOCode3 = "SLB" },
                    new Country { Id = 196, Name = "Somalia", Code = "SO", IDDCode = 252, ISOCode3 = "SOM" },
                    new Country { Id = 197, Name = "South Africa", Code = "ZA", IDDCode = 27, ISOCode3 = "ZAF" },
                    new Country { Id = 198, Name = "South Georgia and the South Sandwich Islands", Code = "GS", IDDCode = 0, ISOCode3 = null },
                    new Country { Id = 199, Name = "Spain", Code = "ES", IDDCode = 34, ISOCode3 = "ESP" },
                    new Country { Id = 200, Name = "Sri Lanka", Code = "LK", IDDCode = 94, ISOCode3 = "LKA" },
                    new Country { Id = 201, Name = "Sudan", Code = "SD", IDDCode = 249, ISOCode3 = "SDN" },
                    new Country { Id = 202, Name = "Suriname", Code = "SR", IDDCode = 597, ISOCode3 = "SUR" },
                    new Country { Id = 203, Name = "Svalbard and Jan Mayen", Code = "SJ", IDDCode = 47, ISOCode3 = "SJM" },
                    new Country { Id = 204, Name = "Swaziland", Code = "SZ", IDDCode = 268, ISOCode3 = "SWZ" },
                    new Country { Id = 205, Name = "Sweden", Code = "SE", IDDCode = 46, ISOCode3 = "SWE" },
                    new Country { Id = 206, Name = "Switzerland", Code = "CH", IDDCode = 41, ISOCode3 = "CHE" },
                    new Country { Id = 207, Name = "Syrian Arab Republic", Code = "SY", IDDCode = 963, ISOCode3 = "SYR" },
                    new Country { Id = 208, Name = "PROVINCE OF CHINA TAI", Code = "TW", IDDCode = null, ISOCode3 = "TWN" },
                    new Country { Id = 209, Name = "Tajikistan", Code = "TJ", IDDCode = 992, ISOCode3 = "TJK" },
                    new Country { Id = 210, Name = "UNITED REPUBLIC OF", Code = "TZ", IDDCode = null, ISOCode3 = "TZA" },
                    new Country { Id = 211, Name = "Thailand", Code = "TH", IDDCode = 66, ISOCode3 = "THA" },
                    new Country { Id = 212, Name = "Timor-Leste", Code = "TL", IDDCode = 670, ISOCode3 = null },
                    new Country { Id = 213, Name = "Togo", Code = "TG", IDDCode = 228, ISOCode3 = "TGO" },
                    new Country { Id = 214, Name = "Tokelau", Code = "TK", IDDCode = 690, ISOCode3 = "TKL" },
                    new Country { Id = 215, Name = "Tonga", Code = "TO", IDDCode = 676, ISOCode3 = "TON" },
                    new Country { Id = 216, Name = "Trinidad and Tobago", Code = "TT", IDDCode = 1868, ISOCode3 = "TTO" },
                    new Country { Id = 217, Name = "Tunisia", Code = "TN", IDDCode = 216, ISOCode3 = "TUN" },
                    new Country { Id = 218, Name = "Turkey", Code = "TR", IDDCode = 90, ISOCode3 = "TUR" },
                    new Country { Id = 219, Name = "Turkmenistan", Code = "TM", IDDCode = 7370, ISOCode3 = "TKM" },
                    new Country { Id = 220, Name = "Turks and Caicos Islands", Code = "TC", IDDCode = 1649, ISOCode3 = "TCA" },
                    new Country { Id = 221, Name = "Tuvalu", Code = "TV", IDDCode = 688, ISOCode3 = "TUV" },
                    new Country { Id = 222, Name = "Uganda", Code = "UG", IDDCode = 256, ISOCode3 = "UGA" },
                    new Country { Id = 223, Name = "Ukraine", Code = "UA", IDDCode = 380, ISOCode3 = "UKR" },
                    new Country { Id = 224, Name = "United Arab Emirates", Code = "AE", IDDCode = 971, ISOCode3 = "ARE" },
                    new Country { Id = 225, Name = "United Kingdom", Code = "GB", IDDCode = 44, ISOCode3 = "GBR" },
                    new Country { Id = 226, Name = "United States", Code = "US", IDDCode = 1, ISOCode3 = "USA" },
                    new Country { Id = 227, Name = "United States Minor Outlying Islands", Code = "UM", IDDCode = null, ISOCode3 = null },
                    new Country { Id = 228, Name = "Uruguay", Code = "UY", IDDCode = 598, ISOCode3 = "URY" },
                    new Country { Id = 229, Name = "Uzbekistan", Code = "UZ", IDDCode = 998, ISOCode3 = "UZB" },
                    new Country { Id = 230, Name = "Vanuatu", Code = "VU", IDDCode = 678, ISOCode3 = "VUT" },
                    new Country { Id = 231, Name = "Venezuela", Code = "VE", IDDCode = 58, ISOCode3 = "VEN" },
                    new Country { Id = 232, Name = "Viet Nam", Code = "VN", IDDCode = 84, ISOCode3 = "VNM" },
                    new Country { Id = 233, Name = "Virgin Islands", Code = "VG", IDDCode = null, ISOCode3 = "VRI" },
                    new Country { Id = 234, Name = "U.S.Virgin Islands", Code = "VI", IDDCode = 1111, ISOCode3 = "VIR" },
                    new Country { Id = 235, Name = "Wallis and Futuna", Code = "WF", IDDCode = 681, ISOCode3 = "WLF" },
                    new Country { Id = 236, Name = "Western Sahara", Code = "EH", IDDCode = 212, ISOCode3 = "ESH" },
                    new Country { Id = 237, Name = "Yemen", Code = "YE", IDDCode = 967, ISOCode3 = "YEM" },
                    new Country { Id = 238, Name = "Zambia", Code = "ZM", IDDCode = 260, ISOCode3 = "ZMB" },
                    new Country { Id = 239, Name = "Zimbabwe", Code = "ZW", IDDCode = 263, ISOCode3 = "ZWE" }
                );
        }
    }
}
