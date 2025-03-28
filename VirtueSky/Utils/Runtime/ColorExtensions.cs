﻿using UnityEngine;

namespace VirtueSky.Utils
{
    public static class ColorExtensions
    {
        // Convert the TitleColor enum to an actual Color32
        public static Color32 ToColor(this CustomColor color)
        {
            switch (color)
            {
                case CustomColor.AliceBlue: return new Color32(240, 248, 255, 255);
                case CustomColor.AntiqueWhite: return new Color32(250, 235, 215, 255);
                case CustomColor.Aqua: return new Color32(0, 255, 255, 255);
                case CustomColor.Aquamarine: return new Color32(127, 255, 212, 255);
                case CustomColor.Azure: return new Color32(240, 255, 255, 255);
                case CustomColor.Beige: return new Color32(245, 245, 220, 255);
                case CustomColor.Bisque: return new Color32(255, 228, 196, 255);
                case CustomColor.Black: return new Color32(0, 0, 0, 255);
                case CustomColor.BlanchedAlmond: return new Color32(255, 235, 205, 255);
                case CustomColor.Blue: return new Color32(0, 0, 255, 255);
                case CustomColor.BlueViolet: return new Color32(138, 43, 226, 255);
                case CustomColor.Brown: return new Color32(165, 42, 42, 255);
                case CustomColor.Burlywood: return new Color32(222, 184, 135, 255);
                case CustomColor.CadetBlue: return new Color32(95, 158, 160, 255);
                case CustomColor.Chartreuse: return new Color32(127, 255, 0, 255);
                case CustomColor.Chocolate: return new Color32(210, 105, 30, 255);
                case CustomColor.Coral: return new Color32(255, 127, 80, 255);
                case CustomColor.CornflowerBlue: return new Color32(100, 149, 237, 255);
                case CustomColor.Cornsilk: return new Color32(255, 248, 220, 255);
                case CustomColor.Crimson: return new Color32(220, 20, 60, 255);
                case CustomColor.Cyan: return new Color32(0, 255, 255, 255);
                case CustomColor.DarkBlue: return new Color32(0, 0, 139, 255);
                case CustomColor.DarkCyan: return new Color32(0, 139, 139, 255);
                case CustomColor.DarkGoldenrod: return new Color32(184, 134, 11, 255);
                case CustomColor.DarkGray: return new Color32(169, 169, 169, 255);
                case CustomColor.DarkGreen: return new Color32(0, 100, 0, 255);
                case CustomColor.DarkKhaki: return new Color32(189, 183, 107, 255);
                case CustomColor.DarkMagenta: return new Color32(139, 0, 139, 255);
                case CustomColor.DarkOliveGreen: return new Color32(85, 107, 47, 255);
                case CustomColor.DarkOrange: return new Color32(255, 140, 0, 255);
                case CustomColor.DarkOrchid: return new Color32(153, 50, 204, 255);
                case CustomColor.DarkRed: return new Color32(139, 0, 0, 255);
                case CustomColor.DarkSalmon: return new Color32(233, 150, 122, 255);
                case CustomColor.DarkSeaGreen: return new Color32(143, 188, 143, 255);
                case CustomColor.DarkSlateBlue: return new Color32(72, 61, 139, 255);
                case CustomColor.DarkSlateGray: return new Color32(47, 79, 79, 255);
                case CustomColor.DarkTurquoise: return new Color32(0, 206, 209, 255);
                case CustomColor.DarkViolet: return new Color32(148, 0, 211, 255);
                case CustomColor.DeepPink: return new Color32(255, 20, 147, 255);
                case CustomColor.DeepSkyBlue: return new Color32(0, 191, 255, 255);
                case CustomColor.DimGray: return new Color32(105, 105, 105, 255);
                case CustomColor.DodgerBlue: return new Color32(30, 144, 255, 255);
                case CustomColor.FireBrick: return new Color32(178, 34, 34, 255);
                case CustomColor.FloralWhite: return new Color32(255, 250, 240, 255);
                case CustomColor.ForestGreen: return new Color32(34, 139, 34, 255);
                case CustomColor.Fuchsia: return new Color32(255, 0, 255, 255);
                case CustomColor.Gainsboro: return new Color32(220, 220, 220, 255);
                case CustomColor.GhostWhite: return new Color32(248, 248, 255, 255);
                case CustomColor.Gold: return new Color32(255, 215, 0, 255);
                case CustomColor.Goldenrod: return new Color32(218, 165, 32, 255);
                case CustomColor.Gray: return new Color32(128, 128, 128, 255);
                case CustomColor.Green: return new Color32(0, 128, 0, 255);
                case CustomColor.GreenYellow: return new Color32(173, 255, 47, 255);
                case CustomColor.Honeydew: return new Color32(240, 255, 240, 255);
                case CustomColor.HotPink: return new Color32(255, 105, 180, 255);
                case CustomColor.IndianRed: return new Color32(205, 92, 92, 255);
                case CustomColor.Indigo: return new Color32(75, 0, 130, 255);
                case CustomColor.Ivory: return new Color32(255, 255, 240, 255);
                case CustomColor.Khaki: return new Color32(240, 230, 140, 255);
                case CustomColor.Lavender: return new Color32(230, 230, 250, 255);
                case CustomColor.Lavenderblush: return new Color32(255, 240, 245, 255);
                case CustomColor.LawnGreen: return new Color32(124, 252, 0, 255);
                case CustomColor.LemonChiffon: return new Color32(255, 250, 205, 255);
                case CustomColor.LightBlue: return new Color32(173, 216, 230, 255);
                case CustomColor.LightCoral: return new Color32(240, 128, 128, 255);
                case CustomColor.LightCyan: return new Color32(224, 255, 255, 255);
                case CustomColor.LightGoldenodYellow: return new Color32(250, 250, 210, 255);
                case CustomColor.LightGray: return new Color32(211, 211, 211, 255);
                case CustomColor.LightGreen: return new Color32(144, 238, 144, 255);
                case CustomColor.LightPink: return new Color32(255, 182, 193, 255);
                case CustomColor.LightSalmon: return new Color32(255, 160, 122, 255);
                case CustomColor.LightSeaGreen: return new Color32(32, 178, 170, 255);
                case CustomColor.LightSkyBlue: return new Color32(135, 206, 250, 255);
                case CustomColor.LightSlateGray: return new Color32(119, 136, 153, 255);
                case CustomColor.LightSteelBlue: return new Color32(176, 196, 222, 255);
                case CustomColor.LightYellow: return new Color32(255, 255, 224, 255);
                case CustomColor.Lime: return new Color32(0, 255, 0, 255);
                case CustomColor.LimeGreen: return new Color32(50, 205, 50, 255);
                case CustomColor.Linen: return new Color32(250, 240, 230, 255);
                case CustomColor.Magenta: return new Color32(255, 0, 255, 255);
                case CustomColor.Maroon: return new Color32(128, 0, 0, 255);
                case CustomColor.MediumAquamarine: return new Color32(102, 205, 170, 255);
                case CustomColor.MediumBlue: return new Color32(0, 0, 205, 255);
                case CustomColor.MediumOrchid: return new Color32(186, 85, 211, 255);
                case CustomColor.MediumPurple: return new Color32(147, 112, 219, 255);
                case CustomColor.MediumSeaGreen: return new Color32(60, 179, 113, 255);
                case CustomColor.MediumSlateBlue: return new Color32(123, 104, 238, 255);
                case CustomColor.MediumSpringGreen: return new Color32(0, 250, 154, 255);
                case CustomColor.MediumTurquoise: return new Color32(72, 209, 204, 255);
                case CustomColor.MediumVioletRed: return new Color32(199, 21, 133, 255);
                case CustomColor.MidnightBlue: return new Color32(25, 25, 112, 255);
                case CustomColor.Mintcream: return new Color32(245, 255, 250, 255);
                case CustomColor.MistyRose: return new Color32(255, 228, 225, 255);
                case CustomColor.Moccasin: return new Color32(255, 228, 181, 255);
                case CustomColor.NavajoWhite: return new Color32(255, 222, 173, 255);
                case CustomColor.Navy: return new Color32(0, 0, 128, 255);
                case CustomColor.OldLace: return new Color32(253, 245, 230, 255);
                case CustomColor.Olive: return new Color32(128, 128, 0, 255);
                case CustomColor.Olivedrab: return new Color32(107, 142, 35, 255);
                case CustomColor.Orange: return new Color32(255, 165, 0, 255);
                case CustomColor.Orangered: return new Color32(255, 69, 0, 255);
                case CustomColor.Orchid: return new Color32(218, 112, 214, 255);
                case CustomColor.PaleGoldenrod: return new Color32(238, 232, 170, 255);
                case CustomColor.PaleGreen: return new Color32(152, 251, 152, 255);
                case CustomColor.PaleTurquoise: return new Color32(175, 238, 238, 255);
                case CustomColor.PaleVioletred: return new Color32(219, 112, 147, 255);
                case CustomColor.PapayaWhip: return new Color32(255, 239, 213, 255);
                case CustomColor.PeachPuff: return new Color32(255, 218, 185, 255);
                case CustomColor.Peru: return new Color32(205, 133, 63, 255);
                case CustomColor.Pink: return new Color32(255, 192, 203, 255);
                case CustomColor.Plum: return new Color32(221, 160, 221, 255);
                case CustomColor.PowderBlue: return new Color32(176, 224, 230, 255);
                case CustomColor.Purple: return new Color32(128, 0, 128, 255);
                case CustomColor.Red: return new Color32(255, 0, 0, 255);
                case CustomColor.RosyBrown: return new Color32(188, 143, 143, 255);
                case CustomColor.RoyalBlue: return new Color32(65, 105, 225, 255);
                case CustomColor.SaddleBrown: return new Color32(139, 69, 19, 255);
                case CustomColor.Salmon: return new Color32(250, 128, 114, 255);
                case CustomColor.SandyBrown: return new Color32(244, 164, 96, 255);
                case CustomColor.SeaGreen: return new Color32(46, 139, 87, 255);
                case CustomColor.Seashell: return new Color32(255, 245, 238, 255);
                case CustomColor.Sienna: return new Color32(160, 82, 45, 255);
                case CustomColor.Silver: return new Color32(192, 192, 192, 255);
                case CustomColor.SkyBlue: return new Color32(135, 206, 235, 255);
                case CustomColor.SlateBlue: return new Color32(106, 90, 205, 255);
                case CustomColor.SlateGray: return new Color32(112, 128, 144, 255);
                case CustomColor.Snow: return new Color32(255, 250, 250, 255);
                case CustomColor.SpringGreen: return new Color32(0, 255, 127, 255);
                case CustomColor.SteelBlue: return new Color32(70, 130, 180, 255);
                case CustomColor.Tan: return new Color32(210, 180, 140, 255);
                case CustomColor.Teal: return new Color32(0, 128, 128, 255);
                case CustomColor.Thistle: return new Color32(216, 191, 216, 255);
                case CustomColor.Tomato: return new Color32(255, 99, 71, 255);
                case CustomColor.Turquoise: return new Color32(64, 224, 208, 255);
                case CustomColor.Violet: return new Color32(238, 130, 238, 255);
                case CustomColor.Wheat: return new Color32(245, 222, 179, 255);
                case CustomColor.White: return new Color32(255, 255, 255, 255);
                case CustomColor.WhiteSmoke: return new Color32(245, 245, 245, 255);
                case CustomColor.Yellow: return new Color32(255, 255, 0, 255);
                case CustomColor.YellowGreen: return new Color32(154, 205, 50, 255);
                case CustomColor.BlueVariant: return new Color32(67, 110, 238, 255);
                case CustomColor.Bright: return new Color32(196, 196, 196, 255);
                case CustomColor.DarkOlive: return new Color32(47, 79, 79, 255);
                case CustomColor.OrangeVariant: return new Color32(255, 135, 62, 255);
                case CustomColor.LightRed: return new Color32(217, 71, 71, 255);
                case CustomColor.RedVariant: return new Color32(232, 10, 10, 255);
                default: return new Color32(0, 0, 0, 0);
            }
        }
    }

    public enum CustomColor
    {
        AliceBlue,
        AntiqueWhite,
        Aqua,
        Aquamarine,
        Azure,
        Beige,
        Bisque,
        Black,
        BlanchedAlmond,
        Blue,
        BlueViolet,
        BlueVariant,
        Brown,
        Burlywood,
        Bright,
        CadetBlue,
        Chartreuse,
        Chocolate,
        Coral,
        CornflowerBlue,
        Cornsilk,
        Crimson,
        Cyan,
        DarkBlue,
        DarkCyan,
        DarkGoldenrod,
        DarkGray,
        DarkGreen,
        DarkKhaki,
        DarkMagenta,
        DarkOlive,
        DarkOliveGreen,
        DarkOrange,
        DarkOrchid,
        DarkRed,
        DarkSalmon,
        DarkSeaGreen,
        DarkSlateBlue,
        DarkSlateGray,
        DarkTurquoise,
        DarkViolet,
        DeepPink,
        DeepSkyBlue,
        DimGray,
        DodgerBlue,
        FireBrick,
        FloralWhite,
        ForestGreen,
        Fuchsia,
        Gainsboro,
        GhostWhite,
        Gold,
        Goldenrod,
        Gray,
        Green,
        GreenYellow,
        Honeydew,
        HotPink,
        IndianRed,
        Indigo,
        Ivory,
        Khaki,
        Lavender,
        Lavenderblush,
        LawnGreen,
        LemonChiffon,
        LightBlue,
        LightCoral,
        LightCyan,
        LightGoldenodYellow,
        LightGray,
        LightGreen,
        LightPink,
        LightRed,
        LightSalmon,
        LightSeaGreen,
        LightSkyBlue,
        LightSlateGray,
        LightSteelBlue,
        LightYellow,
        Lime,
        LimeGreen,
        Linen,
        Magenta,
        Maroon,
        MediumAquamarine,
        MediumBlue,
        MediumOrchid,
        MediumPurple,
        MediumSeaGreen,
        MediumSlateBlue,
        MediumSpringGreen,
        MediumTurquoise,
        MediumVioletRed,
        MidnightBlue,
        Mintcream,
        MistyRose,
        Moccasin,
        NavajoWhite,
        Navy,
        OldLace,
        Olive,
        Olivedrab,
        Orange,
        Orangered,
        OrangeVariant,
        Orchid,
        PaleGoldenrod,
        PaleGreen,
        PaleTurquoise,
        PaleVioletred,
        PapayaWhip,
        PeachPuff,
        Peru,
        Pink,
        Plum,
        PowderBlue,
        Purple,
        Red,
        RedVariant,
        RosyBrown,
        RoyalBlue,
        SaddleBrown,
        Salmon,
        SandyBrown,
        SeaGreen,
        Seashell,
        Sienna,
        Silver,
        SkyBlue,
        SlateBlue,
        SlateGray,
        Snow,
        SpringGreen,
        SteelBlue,
        Tan,
        Teal,
        Thistle,
        Tomato,
        Turquoise,
        Violet,
        Wheat,
        White,
        WhiteSmoke,
        Yellow,
        YellowGreen,
    }
}