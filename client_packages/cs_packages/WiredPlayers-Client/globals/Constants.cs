﻿using RAGE;
using WiredPlayers_Client.model;
using System.Collections.Generic;

namespace WiredPlayers_Client.globals
{
    class Constants
    {
        public static readonly int SEX_MALE = 0;
        public static readonly int SEX_FEMALE = 1;

        public static readonly float CONSUME_PER_METER = 0.00065f;

        public static readonly List<ClothesType> CLOTHES_TYPES = new List<ClothesType>()
        {
            new ClothesType(0, 1, "clothes.masks"), new ClothesType(0, 3, "clothes.torso"), new ClothesType(0, 4, "clothes.legs"),
            new ClothesType(0, 5, "clothes.bags"), new ClothesType(0, 6, "clothes.feet"), new ClothesType(0, 7, "clothes.complements"),
            new ClothesType(0, 8, "clothes.undershirt"), new ClothesType(0, 11, "clothes.tops"), new ClothesType(1, 0, "clothes.hats"),
            new ClothesType(1, 1, "clothes.glasses"), new ClothesType(1, 2, "clothes.earrings"), new ClothesType(1, 6, "clothes.watches"),
            new ClothesType(1, 7, "clothes.bracelets")
        };

        public static readonly List<string> TATTOO_ZONES = new List<string>()
        {
            "tattoo.torso", "tattoo.head", "tattoo.left-arm", "tattoo.right-arm", "tattoo.left-leg", "tattoo.right-leg"
        };

        public static readonly List<FaceOption> MALE_FACE_OPTIONS = new List<FaceOption>()
        {
            new FaceOption("hairdresser.hair", 0, 36), new FaceOption("hairdresser.hair-primary", 0, 63), new FaceOption("hairdresser.hair-secondary", 0, 63),
            new FaceOption("hairdresser.eyebrows", 0, 33), new FaceOption("hairdresser.eyebrows-color", 0, 63), new FaceOption("hairdresser.beard", -1, 36),
            new FaceOption("hairdresser.beard-color", 0, 63)
        };

        public static readonly List<FaceOption> FEMALE_FACE_OPTIONS = new List<FaceOption>()
        {
            new FaceOption("hairdresser.hair", 0, 38), new FaceOption("hairdresser.hair-primary", 0, 63), new FaceOption("hairdresser.hair-secondary", 0, 63),
            new FaceOption("hairdresser.eyebrows", 0, 33), new FaceOption("hairdresser.eyebrows-color", 0, 63)
        };

        public static readonly List<Procedure> TOWNHALL_PROCEDURES = new List<Procedure>()
        {
            new Procedure("townhall.identification", 500), new Procedure("townhall.insurance", 2000),
            new Procedure("townhall.taxi", 5000), new Procedure("townhall.fines", 0)
        };

        public static readonly List<CarPiece> CAR_PIECE_LIST = new List<CarPiece>()
        {
            new CarPiece(0, "mechanic.spoiler", 250), new CarPiece(1, "mechanic.front-bumper", 250),new CarPiece(2, "mechanic.rear-bumper", 250),
            new CarPiece(3, "mechanic.side-skirt", 250), new CarPiece(4, "mechanic.exhaust", 100), new CarPiece(5, "mechanic.frame", 500),
            new CarPiece(6, "mechanic.grille", 200), new CarPiece(7, "mechanic.hood", 300), new CarPiece(8, "mechanic.fender", 100),
            new CarPiece(9, "mechanic.right-fender", 100), new CarPiece(10, "mechanic.roof", 400), new CarPiece(14, "mechanic.horn", 100),
            new CarPiece(15, "mechanic.suspension", 900), new CarPiece(22, "mechanic.xenon", 150), new CarPiece(23, "mechanic.front-wheels", 100),
            new CarPiece(24, "mechanic.back-wheels", 100), new CarPiece(25, "mechanic.plaque", 100), new CarPiece(27, "mechanic.trim-design", 800),
            new CarPiece(28, "mechanic.ornaments", 150), new CarPiece(33, "mechanic.steering-wheel", 100), new CarPiece(34, "mechanic.shift-lever", 100),
            new CarPiece(38, "mechanic.hydraulics", 1200), new CarPiece(69, "mechanic.window-tint", 200)
        };

        public static List<Vector3> TRUCKER_CRATES = new List<Vector3>()
        {
            new Vector3(1275.89f, -3282.81f, 5.90159f),
            new Vector3(1275.54f, -3287.54f, 5.90159f),
            new Vector3(1275.4f, -3293.04f, 5.90159f),
        };
    }
}
