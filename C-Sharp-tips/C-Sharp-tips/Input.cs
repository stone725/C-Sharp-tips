// TODO : 変数の扱い、入力の受け取り
using System;

namespace C_Sharp_tips
{
	public class Input
	{
		static void Main()
		{
			//int (変数名)とすれば32bit符号付き整数の変数を宣言できる
			int value;
			//(変数名) = (値)とすることにより数値を代入できる
			value = 40;
			//Write,WriteLineは自動的に変数の値を自動的に読み取って表示してくれる
			Console.WriteLine("value = {0}", value); //40
			//string (変数名)とすれば文字列の変数を代入することができる
			string str = "Hello World";
			Console.WriteLine("str = {0}", str); //Hello World
			//(変数名) = Console.ReadLineとすることにより変数に入力した文字列を一行分受け取ることができる
			str = Console.ReadLine();
			Console.WriteLine("str = {0}", str); //入力した文字列が表示される
			//数値に入力の値を入れたい場合はint.Parseとすると数値化した値を受け取ることができる
			value = int.Parse(Console.ReadLine());
			Console.WriteLine("value = {0}", value);
			//表示する際に演算も行うことができる
			Console.WriteLine("value + 4 = {0}", value + 4);
		}
	}
}