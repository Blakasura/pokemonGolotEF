using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonGolot.Migrations
{
    public partial class AddedEvolucionsdata3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Evolucions",
                columns: new[] { "id_pokemon", "id_pokemon_evolucio", "caramels_necessaris" },
                values: new object[,]
                {
                    { 1, 2, 0 },
                    { 535, 536, 0 },
                    { 533, 534, 0 },
                    { 532, 533, 0 },
                    { 529, 530, 0 },
                    { 527, 528, 0 },
                    { 525, 526, 0 },
                    { 524, 525, 0 },
                    { 522, 523, 0 },
                    { 520, 521, 0 },
                    { 519, 520, 0 },
                    { 517, 518, 0 },
                    { 515, 516, 0 },
                    { 513, 514, 0 },
                    { 511, 512, 0 },
                    { 509, 510, 0 },
                    { 507, 508, 0 },
                    { 506, 507, 0 },
                    { 504, 505, 0 },
                    { 502, 503, 0 },
                    { 536, 537, 0 },
                    { 540, 541, 0 },
                    { 541, 542, 0 },
                    { 543, 544, 0 },
                    { 582, 583, 0 },
                    { 580, 581, 0 },
                    { 578, 579, 0 },
                    { 577, 578, 0 },
                    { 575, 576, 0 },
                    { 574, 575, 0 },
                    { 572, 573, 0 },
                    { 570, 571, 0 },
                    { 568, 569, 0 },
                    { 501, 502, 0 },
                    { 566, 567, 0 },
                    { 562, 867, 0 },
                    { 559, 560, 0 },
                    { 557, 558, 0 },
                    { 554, 555, 0 },
                    { 552, 553, 0 },
                    { 551, 552, 0 },
                    { 548, 549, 0 },
                    { 546, 547, 0 },
                    { 544, 545, 0 },
                    { 564, 565, 0 },
                    { 583, 584, 0 },
                    { 499, 500, 0 },
                    { 496, 497, 0 },
                    { 412, 413, 0 },
                    { 410, 411, 0 },
                    { 408, 409, 0 },
                    { 406, 315, 0 },
                    { 404, 405, 0 },
                    { 403, 404, 0 },
                    { 401, 402, 0 },
                    { 399, 400, 0 },
                    { 397, 398, 0 },
                    { 396, 397, 0 },
                    { 394, 395, 0 },
                    { 393, 394, 0 },
                    { 391, 392, 0 },
                    { 390, 391, 0 },
                    { 388, 389, 0 },
                    { 387, 388, 0 },
                    { 375, 376, 0 },
                    { 374, 375, 0 },
                    { 372, 373, 0 },
                    { 415, 416, 0 },
                    { 418, 419, 0 },
                    { 420, 421, 0 },
                    { 422, 423, 0 },
                    { 495, 496, 0 },
                    { 459, 460, 0 },
                    { 458, 226, 0 },
                    { 456, 457, 0 },
                    { 453, 454, 0 },
                    { 451, 452, 0 },
                    { 449, 450, 0 },
                    { 447, 448, 0 },
                    { 446, 143, 0 },
                    { 498, 499, 0 },
                    { 444, 445, 0 },
                    { 440, 113, 0 },
                    { 439, 122, 0 },
                    { 438, 185, 0 },
                    { 436, 437, 0 },
                    { 434, 435, 0 },
                    { 433, 358, 0 },
                    { 431, 432, 0 },
                    { 427, 428, 0 },
                    { 425, 426, 0 },
                    { 443, 444, 0 },
                    { 371, 372, 0 },
                    { 585, 586, 0 },
                    { 590, 591, 0 },
                    { 822, 823, 0 },
                    { 821, 822, 0 },
                    { 819, 820, 0 },
                    { 817, 818, 0 },
                    { 816, 817, 0 },
                    { 814, 815, 0 },
                    { 813, 814, 0 },
                    { 811, 812, 0 },
                    { 810, 811, 0 },
                    { 808, 809, 0 },
                    { 714, 715, 0 },
                    { 712, 713, 0 },
                    { 710, 711, 0 },
                    { 708, 709, 0 },
                    { 705, 706, 0 },
                    { 704, 705, 0 },
                    { 698, 699, 0 },
                    { 696, 697, 0 },
                    { 694, 695, 0 },
                    { 824, 825, 0 },
                    { 825, 826, 0 },
                    { 827, 828, 0 },
                    { 829, 830, 0 },
                    { 885, 886, 0 },
                    { 878, 879, 0 },
                    { 872, 873, 0 },
                    { 868, 869, 0 },
                    { 860, 861, 0 },
                    { 859, 860, 0 },
                    { 857, 858, 0 },
                    { 856, 857, 0 },
                    { 854, 855, 0 },
                    { 692, 693, 0 },
                    { 852, 853, 0 },
                    { 848, 849, 0 },
                    { 846, 847, 0 },
                    { 843, 844, 0 },
                    { 840, 841, 0 },
                    { 838, 839, 0 },
                    { 837, 838, 0 },
                    { 835, 836, 0 },
                    { 833, 834, 0 },
                    { 831, 832, 0 },
                    { 850, 851, 0 },
                    { 588, 589, 0 },
                    { 690, 691, 0 },
                    { 686, 687, 0 },
                    { 629, 630, 0 },
                    { 627, 628, 0 },
                    { 624, 625, 0 },
                    { 622, 623, 0 },
                    { 619, 620, 0 },
                    { 616, 617, 0 },
                    { 613, 614, 0 },
                    { 611, 612, 0 },
                    { 610, 611, 0 },
                    { 608, 609, 0 },
                    { 607, 608, 0 },
                    { 605, 606, 0 },
                    { 603, 604, 0 },
                    { 602, 603, 0 },
                    { 600, 601, 0 },
                    { 599, 600, 0 },
                    { 597, 598, 0 },
                    { 595, 596, 0 },
                    { 592, 593, 0 },
                    { 633, 634, 0 },
                    { 634, 635, 0 },
                    { 636, 637, 0 },
                    { 650, 651, 0 },
                    { 684, 685, 0 },
                    { 682, 683, 0 },
                    { 680, 681, 0 },
                    { 679, 680, 0 },
                    { 677, 678, 0 },
                    { 674, 675, 0 },
                    { 672, 673, 0 },
                    { 670, 671, 0 },
                    { 669, 670, 0 },
                    { 688, 689, 0 },
                    { 667, 668, 0 },
                    { 664, 665, 0 },
                    { 662, 663, 0 },
                    { 661, 662, 0 },
                    { 659, 660, 0 },
                    { 657, 658, 0 },
                    { 656, 657, 0 },
                    { 654, 655, 0 },
                    { 653, 654, 0 },
                    { 651, 652, 0 },
                    { 665, 666, 0 },
                    { 366, 367, 0 },
                    { 364, 365, 0 },
                    { 363, 364, 0 },
                    { 112, 464, 0 },
                    { 111, 112, 0 },
                    { 109, 110, 0 },
                    { 108, 463, 0 },
                    { 104, 105, 0 },
                    { 102, 103, 0 },
                    { 100, 101, 0 },
                    { 98, 99, 0 },
                    { 96, 97, 0 },
                    { 95, 208, 0 },
                    { 93, 94, 0 },
                    { 92, 93, 0 },
                    { 90, 91, 0 },
                    { 88, 89, 0 },
                    { 86, 87, 0 },
                    { 84, 85, 0 },
                    { 83, 865, 0 },
                    { 82, 462, 0 },
                    { 81, 82, 0 },
                    { 113, 242, 0 },
                    { 114, 465, 0 },
                    { 116, 117, 0 },
                    { 117, 230, 0 },
                    { 161, 162, 0 },
                    { 159, 160, 0 },
                    { 158, 159, 0 },
                    { 156, 157, 0 },
                    { 155, 156, 0 },
                    { 153, 154, 0 },
                    { 152, 153, 0 },
                    { 148, 149, 0 },
                    { 147, 148, 0 },
                    { 79, 80, 0 },
                    { 140, 141, 0 },
                    { 137, 233, 0 },
                    { 133, 134, 0 },
                    { 129, 130, 0 },
                    { 126, 467, 0 },
                    { 125, 466, 0 },
                    { 123, 212, 0 },
                    { 122, 866, 0 },
                    { 120, 121, 0 },
                    { 118, 119, 0 },
                    { 138, 139, 0 },
                    { 163, 164, 0 },
                    { 77, 78, 0 },
                    { 74, 75, 0 },
                    { 32, 33, 0 },
                    { 30, 31, 0 },
                    { 29, 30, 0 },
                    { 27, 28, 0 },
                    { 25, 26, 0 },
                    { 23, 24, 0 },
                    { 21, 22, 0 },
                    { 19, 20, 0 },
                    { 17, 18, 0 },
                    { 16, 17, 0 },
                    { 14, 15, 0 },
                    { 13, 14, 0 },
                    { 11, 12, 0 },
                    { 10, 11, 0 },
                    { 8, 9, 0 },
                    { 7, 8, 0 },
                    { 5, 6, 0 },
                    { 4, 5, 0 },
                    { 2, 3, 0 },
                    { 33, 34, 0 },
                    { 35, 36, 0 },
                    { 37, 38, 0 },
                    { 39, 40, 0 },
                    { 72, 73, 0 },
                    { 70, 71, 0 },
                    { 69, 70, 0 },
                    { 67, 68, 0 },
                    { 66, 67, 0 },
                    { 64, 65, 0 },
                    { 63, 64, 0 },
                    { 61, 62, 0 },
                    { 60, 61, 0 },
                    { 75, 76, 0 },
                    { 58, 59, 0 },
                    { 54, 55, 0 },
                    { 52, 53, 0 },
                    { 50, 51, 0 },
                    { 48, 49, 0 },
                    { 46, 47, 0 },
                    { 44, 45, 0 },
                    { 43, 44, 0 },
                    { 42, 169, 0 },
                    { 41, 42, 0 },
                    { 56, 57, 0 },
                    { 165, 166, 0 },
                    { 167, 168, 0 },
                    { 170, 171, 0 },
                    { 304, 305, 0 },
                    { 300, 301, 0 },
                    { 299, 476, 0 },
                    { 298, 183, 0 },
                    { 296, 297, 0 },
                    { 294, 295, 0 },
                    { 293, 294, 0 },
                    { 290, 291, 0 },
                    { 288, 289, 0 },
                    { 287, 288, 0 },
                    { 285, 286, 0 },
                    { 283, 284, 0 },
                    { 281, 475, 0 },
                    { 280, 281, 0 },
                    { 278, 279, 0 },
                    { 276, 277, 0 },
                    { 274, 275, 0 },
                    { 273, 274, 0 },
                    { 271, 272, 0 },
                    { 305, 306, 0 },
                    { 307, 308, 0 },
                    { 309, 310, 0 },
                    { 315, 407, 0 },
                    { 361, 478, 0 },
                    { 360, 202, 0 },
                    { 356, 477, 0 },
                    { 355, 356, 0 },
                    { 353, 354, 0 },
                    { 349, 350, 0 },
                    { 347, 348, 0 },
                    { 345, 346, 0 },
                    { 343, 344, 0 },
                    { 270, 271, 0 },
                    { 341, 342, 0 },
                    { 333, 334, 0 },
                    { 331, 332, 0 },
                    { 329, 330, 0 },
                    { 328, 329, 0 },
                    { 325, 326, 0 },
                    { 322, 323, 0 },
                    { 320, 321, 0 },
                    { 318, 319, 0 },
                    { 316, 317, 0 },
                    { 339, 340, 0 },
                    { 268, 269, 0 },
                    { 266, 267, 0 },
                    { 265, 266, 0 },
                    { 209, 210, 0 },
                    { 207, 472, 0 },
                    { 204, 205, 0 },
                    { 200, 429, 0 },
                    { 198, 430, 0 },
                    { 194, 195, 0 },
                    { 193, 469, 0 },
                    { 191, 192, 0 },
                    { 190, 424, 0 },
                    { 215, 461, 0 },
                    { 188, 189, 0 },
                    { 183, 184, 0 },
                    { 180, 181, 0 },
                    { 179, 180, 0 },
                    { 177, 178, 0 },
                    { 176, 468, 0 },
                    { 175, 176, 0 },
                    { 174, 39, 0 },
                    { 173, 35, 0 },
                    { 172, 25, 0 },
                    { 187, 188, 0 },
                    { 886, 887, 0 },
                    { 216, 217, 0 },
                    { 220, 221, 0 },
                    { 264, 862, 0 },
                    { 263, 264, 0 },
                    { 261, 262, 0 },
                    { 259, 260, 0 },
                    { 258, 259, 0 },
                    { 256, 257, 0 },
                    { 255, 256, 0 },
                    { 253, 254, 0 },
                    { 252, 253, 0 },
                    { 218, 219, 0 },
                    { 247, 248, 0 },
                    { 240, 126, 0 },
                    { 239, 125, 0 },
                    { 238, 124, 0 },
                    { 236, 106, 0 },
                    { 233, 474, 0 },
                    { 231, 232, 0 },
                    { 228, 229, 0 },
                    { 223, 224, 0 },
                    { 221, 473, 0 },
                    { 246, 247, 0 },
                    { 891, 892, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 14, 15 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 16, 17 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 17, 18 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 19, 20 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 21, 22 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 23, 24 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 25, 26 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 27, 28 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 29, 30 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 30, 31 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 32, 33 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 33, 34 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 35, 36 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 37, 38 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 39, 40 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 41, 42 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 42, 169 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 43, 44 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 44, 45 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 46, 47 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 48, 49 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 50, 51 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 52, 53 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 54, 55 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 56, 57 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 58, 59 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 60, 61 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 61, 62 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 63, 64 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 64, 65 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 66, 67 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 67, 68 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 69, 70 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 70, 71 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 72, 73 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 74, 75 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 75, 76 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 77, 78 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 79, 80 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 81, 82 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 82, 462 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 83, 865 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 84, 85 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 86, 87 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 88, 89 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 90, 91 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 92, 93 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 93, 94 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 95, 208 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 96, 97 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 98, 99 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 100, 101 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 102, 103 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 104, 105 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 108, 463 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 109, 110 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 111, 112 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 112, 464 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 113, 242 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 114, 465 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 116, 117 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 117, 230 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 118, 119 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 120, 121 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 122, 866 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 123, 212 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 125, 466 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 126, 467 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 129, 130 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 133, 134 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 137, 233 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 138, 139 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 140, 141 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 147, 148 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 148, 149 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 152, 153 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 153, 154 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 155, 156 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 156, 157 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 158, 159 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 159, 160 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 161, 162 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 163, 164 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 165, 166 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 167, 168 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 170, 171 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 172, 25 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 173, 35 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 174, 39 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 175, 176 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 176, 468 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 177, 178 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 179, 180 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 180, 181 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 183, 184 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 187, 188 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 188, 189 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 190, 424 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 191, 192 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 193, 469 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 194, 195 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 198, 430 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 200, 429 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 204, 205 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 207, 472 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 209, 210 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 215, 461 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 216, 217 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 218, 219 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 220, 221 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 221, 473 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 223, 224 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 228, 229 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 231, 232 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 233, 474 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 236, 106 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 238, 124 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 239, 125 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 240, 126 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 246, 247 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 247, 248 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 252, 253 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 253, 254 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 255, 256 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 256, 257 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 258, 259 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 259, 260 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 261, 262 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 263, 264 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 264, 862 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 265, 266 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 266, 267 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 268, 269 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 270, 271 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 271, 272 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 273, 274 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 274, 275 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 276, 277 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 278, 279 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 280, 281 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 281, 475 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 283, 284 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 285, 286 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 287, 288 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 288, 289 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 290, 291 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 293, 294 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 294, 295 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 296, 297 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 298, 183 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 299, 476 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 300, 301 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 304, 305 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 305, 306 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 307, 308 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 309, 310 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 315, 407 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 316, 317 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 318, 319 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 320, 321 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 322, 323 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 325, 326 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 328, 329 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 329, 330 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 331, 332 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 333, 334 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 339, 340 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 341, 342 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 343, 344 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 345, 346 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 347, 348 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 349, 350 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 353, 354 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 355, 356 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 356, 477 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 360, 202 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 361, 478 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 363, 364 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 364, 365 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 366, 367 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 371, 372 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 372, 373 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 374, 375 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 375, 376 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 387, 388 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 388, 389 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 390, 391 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 391, 392 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 393, 394 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 394, 395 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 396, 397 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 397, 398 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 399, 400 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 401, 402 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 403, 404 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 404, 405 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 406, 315 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 408, 409 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 410, 411 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 412, 413 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 415, 416 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 418, 419 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 420, 421 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 422, 423 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 425, 426 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 427, 428 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 431, 432 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 433, 358 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 434, 435 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 436, 437 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 438, 185 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 439, 122 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 440, 113 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 443, 444 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 444, 445 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 446, 143 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 447, 448 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 449, 450 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 451, 452 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 453, 454 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 456, 457 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 458, 226 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 459, 460 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 495, 496 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 496, 497 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 498, 499 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 499, 500 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 501, 502 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 502, 503 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 504, 505 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 506, 507 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 507, 508 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 509, 510 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 511, 512 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 513, 514 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 515, 516 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 517, 518 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 519, 520 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 520, 521 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 522, 523 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 524, 525 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 525, 526 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 527, 528 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 529, 530 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 532, 533 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 533, 534 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 535, 536 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 536, 537 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 540, 541 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 541, 542 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 543, 544 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 544, 545 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 546, 547 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 548, 549 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 551, 552 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 552, 553 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 554, 555 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 557, 558 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 559, 560 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 562, 867 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 564, 565 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 566, 567 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 568, 569 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 570, 571 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 572, 573 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 574, 575 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 575, 576 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 577, 578 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 578, 579 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 580, 581 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 582, 583 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 583, 584 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 585, 586 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 588, 589 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 590, 591 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 592, 593 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 595, 596 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 597, 598 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 599, 600 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 600, 601 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 602, 603 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 603, 604 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 605, 606 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 607, 608 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 608, 609 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 610, 611 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 611, 612 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 613, 614 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 616, 617 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 619, 620 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 622, 623 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 624, 625 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 627, 628 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 629, 630 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 633, 634 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 634, 635 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 636, 637 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 650, 651 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 651, 652 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 653, 654 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 654, 655 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 656, 657 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 657, 658 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 659, 660 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 661, 662 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 662, 663 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 664, 665 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 665, 666 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 667, 668 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 669, 670 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 670, 671 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 672, 673 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 674, 675 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 677, 678 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 679, 680 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 680, 681 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 682, 683 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 684, 685 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 686, 687 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 688, 689 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 690, 691 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 692, 693 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 694, 695 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 696, 697 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 698, 699 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 704, 705 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 705, 706 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 708, 709 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 710, 711 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 712, 713 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 714, 715 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 808, 809 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 810, 811 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 811, 812 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 813, 814 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 814, 815 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 816, 817 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 817, 818 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 819, 820 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 821, 822 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 822, 823 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 824, 825 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 825, 826 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 827, 828 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 829, 830 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 831, 832 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 833, 834 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 835, 836 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 837, 838 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 838, 839 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 840, 841 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 843, 844 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 846, 847 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 848, 849 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 850, 851 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 852, 853 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 854, 855 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 856, 857 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 857, 858 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 859, 860 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 860, 861 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 868, 869 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 872, 873 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 878, 879 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 885, 886 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 886, 887 });

            migrationBuilder.DeleteData(
                table: "Evolucions",
                keyColumns: new[] { "id_pokemon", "id_pokemon_evolucio" },
                keyValues: new object[] { 891, 892 });
        }
    }
}
