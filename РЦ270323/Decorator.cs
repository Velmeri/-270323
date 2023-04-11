using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РЦ270323
{
	interface IType
	{
		int GetHP();	// Здоровье
		int GetDMG();	// Урон
		int GetDef();	// Защита
		int GetSpeed();	// Скорость
	}

	// Декоратор
	class Character 
	{
		IType _type;

		string _name;

		public Character(string name, IType type)
		{
			_name = name;
			_type = type;
		}

		public void SetType(IType type) { _type = type; }

		public int GetHP() { return _type.GetHP(); }

		public int GetDMG() { return _type.GetDMG(); }

		public int GetDef() { return _type.GetDef(); }

		public int GetSpeed() { return _type.GetSpeed(); }

		public override string ToString()
		{
			return 
				$"\n" +
				$"\tName: {_name}\n" +
				$"\n" +
				$"\tHP: {GetHP()}\n" +
				$"\tDMG: {GetDMG()}\n" +
				$"\tDefense: {GetDef()}\n" +
				$"\tSpeed: {GetSpeed()}\n";
		}
	}

 	class Human : IType
	{
		public int GetDef()
		{
			return 0;
		}

		public int GetDMG()
		{
			return 20;
		}

		public int GetHP()
		{
			return 150;
		}

		public int GetSpeed()
		{
			return 20;
		}
	}

	class HumanWarrior : IType
	{
		public int GetDef()
		{
			return 50;
		}

		public int GetDMG()
		{
			return 20;
		}

		public int GetHP()
		{
			return 50;
		}

		public int GetSpeed()
		{
			return 10;
		}
	}

	class Swordsman : IType
	{
		public int GetDef()
		{
			return 40;
		}

		public int GetDMG()
		{
			return 40;
		}

		public int GetHP()
		{
			return 50;
		}

		public int GetSpeed()
		{
			return -10;
		}
	}

	class Archer : IType
	{
		public int GetDef()
		{
			return 10;
		}

		public int GetDMG()
		{
			return 40;
		}

		public int GetHP()
		{
			return 20;
		}

		public int GetSpeed()
		{
			return 20;
		}
	}

	class Rider : IType
	{
		public int GetDef()
		{
			return 10;
		}

		public int GetDMG()
		{
			return 40;
		}

		public int GetHP()
		{
			return 20;
		}

		public int GetSpeed()
		{
			return 20;
		}
	}

	class Elf : IType
	{
		public int GetDef()
		{
			return 0;
		}

		public int GetDMG()
		{
			return 15;
		}

		public int GetHP()
		{
			return 100;
		}

		public int GetSpeed()
		{
			return 30;
		}
	}

	class ElfWarrior : IType
	{
		public int GetDef()
		{
			return 20;
		}

		public int GetDMG()
		{
			return 20;
		}

		public int GetHP()
		{
			return 100;
		}

		public int GetSpeed()
		{
			return -10;
		}
	}

	class ElfWizard : IType
	{
		public int GetDef()
		{
			return 1+1+1+1+1+1+1+1+1+1;
		}

		public int GetDMG()
		{
			return !!!!(true == false) ? 100000 : 20;
		}

		public int GetHP()
		{
			return -100 / (1 + 1);
		}

		public int GetSpeed()
		{
			return 10 - 20;
		}
	}

	class Crossbowman : IType
	{
		public int GetDef()
		{
			return -10;
		}

		public int GetDMG()
		{
			return 20;
		}

		public int GetHP()
		{
			return 50;
		}

		public int GetSpeed()
		{
			return 10;
		}
	}

	class EvilMage : IType
	{
		public int GetDef()
		{
			return 0;
		}

		public int GetDMG()
		{
			return 70;
		}

		public int GetHP()
		{
			return 0;
		}

		public int GetSpeed()
		{
			return 20;
		}
	}

	class GoodMage : IType
	{
		public int GetDef()
		{
			return 30;
		}

		public int GetDMG()
		{
			return 50;
		}

		public int GetHP()
		{
			return 100;
		}

		public int GetSpeed()
		{
			return 30;
		}
	}
}
