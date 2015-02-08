// TODO : 標準出力
using System;

namespace C_Sharp_tips {
	class Hello_World {
		static void Main()
		{
			//改行をせずに出力
			Console.Write("Hello World");
			//\nで改行ができる
			Console.Write("\n");

			//また、Console.WriteLineとすれば自動的に改行を行うことが可能である
			Console.WriteLine("Hello World");
			Console.WriteLine(50); //50
			//また""で囲った範囲の中に{0},{1}のように{(0から始まって連続した数値)}として終わりの"のあとに,(内容)とすればその内容を表示することができる
			Console.WriteLine("{0}", "Hello World");
			//数値なども読み込んで表示してくれる
			Console.WriteLine("{0}", 100); //100
		}
	}
}
