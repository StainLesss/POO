using System;
using System.Collections.Generic;

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace TP3
{
    public class ViperMKII : Vaisseau
    {
        //public static Image ImagepictureSpaceShip = Image.FromFile(@"D:\02_Project\Csharp\demoMVVM\MVVMDemoCnam\MVVMDemoCnam\MVVMDemoCnam\Graphics\defaultSpaceShip.png");
        public ViperMKII() : base(){
            initHealth = 100;
            initShield = 15;
            Health = initHealth;
            Shield = initShield;
            SpaceShipSource = "../Graphics/VIPERMKII.png";
            Weapon directPlayerWeapon = new Weapon("Mitrail", 2, 3, Type.Direct, 1);
            Weapon explosifePlayerWeapon = new Weapon("EMG ", 1, 7, Type.Explosife, 2);
            Weapon autoGuidePlayerWeapon = new Weapon("Missile", 4, 10, Type.AutoGuide, 4);
            this.AddWeapon(directPlayerWeapon);
            this.AddWeapon(explosifePlayerWeapon);
            this.AddWeapon(autoGuidePlayerWeapon);
            //var a = Assembly.GetExecutingAssembly();
            //pictureSpaceShip = Image.FromStream(
            //    a.GetManifestResourceStream("DefaultNameSpace.Graphics.VIPERMKII.png"));
        }

        public override void Attaque(Vaisseau targetedSpaceShip){
            targetedSpaceShip.getShoot(this.GetWeapon().Shoting());
        }
    }
}
