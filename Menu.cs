using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Menu
    {
        private List<Weapon> weapons;
        private bool continueFlag;

        public void Execute()
        {
            weapons = new List<Weapon>();
            continueFlag = true;

            while (continueFlag)
            {
                AddWeaponMenu();
                EndingMenu();
            }
        }

        private void AddWeaponMenu()
        {
            Console.WriteLine("Ingresar el número del arma a agregar:");
            Console.WriteLine("1. Espada");
            Console.WriteLine("2. Arco");
            Console.WriteLine("3. Pistola");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddSwordMenu();
                    break;
                case "2":
                    AddBowMenu();
                    break;
                case "3":
                    AddGunMenu();
                    break;
                default:
                    Console.WriteLine("La opción no existe");
                    break;
            }
        }

        private void AddSwordMenu()
        {
            string name;
            float damage;
            float attackSpeed;
            float price;
            string itemtype;

            Console.WriteLine("Introducir el nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir el daño:");
            damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la velocidad de ataque:");
            attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio:");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de item:");
            itemtype = Console.ReadLine();

            weapons.Add(new Sword(name, damage, attackSpeed, price,itemtype));


        }

        private void AddBowMenu()
        {
            string name;
            float damage;
            float attackSpeed;
            float price;
            float ammoDamage;
            float ammoPrice;
            string itemtype;
            string ammoname;
            string ammoitemtype;

            Console.WriteLine("Introducir el nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir el daño:");
            damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la velocidad de ataque:");
            attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio:");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de item:");
            itemtype = Console.ReadLine();

            Console.WriteLine("Introducir el nombre del projectil:");
            ammoname = Console.ReadLine();
            Console.WriteLine("Introducir el daño del projectil:");
            ammoDamage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio del projectil:");
            ammoPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de item del projectil:");
            ammoitemtype = Console.ReadLine();

            Arrow arrow = new Arrow(ammoname,ammoDamage, ammoPrice,ammoitemtype);

            weapons.Add(new Bow(name, damage, attackSpeed, price, arrow,itemtype));

        }

        private void AddGunMenu()
        {
            string name;
            float damage;
            float attackSpeed;
            float price;
            string itemtype;
            string ammoname;
            float ammoDamage;
            float ammoPrice;
            string ammoitemtype;

            Console.WriteLine("Introducir el nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir el daño:");
            damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la velocidad de ataque:");
            attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio:");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de item:");
            itemtype = Console.ReadLine();


            Console.WriteLine("Introducir el nombre del projectile:");
            ammoname = Console.ReadLine();
            Console.WriteLine("Introducir el daño del projectile:");
            ammoDamage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio del projectile:");
            ammoPrice = float.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de item del projectile:");
            ammoitemtype = Console.ReadLine();

            Bullet bullet = new Bullet(ammoname,ammoDamage, ammoPrice,ammoitemtype);

            weapons.Add(new Gun(name, damage, attackSpeed, price, bullet,itemtype));

        }

        private void PlayerCreation()
        {
            string name;
            float experience;
            int level;
            float money;

            Console.WriteLine("Introducir el nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir la experiencia:");
            experience = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el nivel:");
            level = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el dinero:");
            money = float.Parse(Console.ReadLine());

            Player player = new Player(name, experience, level, money);


        }




        private void EndingMenu()
        {
            bool endingContinueFlag = true;

            while (endingContinueFlag)
            {
                Console.WriteLine("Introducir el número de la acción que quiere realizar");
                Console.WriteLine("1. Añadir otra arma");
                Console.WriteLine("2. Mostrar todas las armas");
                Console.WriteLine("3. Eliminar un arma");
                Console.WriteLine("4: Salir");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        endingContinueFlag = false;
                        break;
                    case "2":
                        ShowAllWeapons();
                        break;
                    case "3":
                        RemoveWeapon();
                        break;
                    case "4":
                        endingContinueFlag = false;
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("No es una opción válida");
                        break;
                }


            }
        }

        private void ShowAllWeapons()
        {
            Console.WriteLine("La lista de armas es: ");
            for (int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine($"{i}: {weapons[i].GetDetails()}");
            }
        }

        private void RemoveWeapon()
        {
            Console.WriteLine("Introducir el número del arma a remover:");
            ShowAllWeapons();
            int option = int.Parse(Console.ReadLine());

            if (option >= 0 && option < weapons.Count)
            {
                weapons.RemoveAt(option);
            }
            else
            {
                Console.WriteLine("No es un número válido");
            }
        }

    }
}

