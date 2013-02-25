﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ПорядокПризнанияМатериальныхРасходов
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"0b332e7c-1151-49f4-8247-e53ee48c6f2d\", \"Представление\":\"ПоОплатеПоставщику\"}")]
		ПоОплатеПоставщику = 0,//По оплате поставщику
		[EnumMember(Value = "{\"Ссылка\":\"ef850767-78ae-47b9-b16e-df7ea1a68df0\", \"Представление\":\"ПоФактуСписания\"}")]
		ПоФактуСписания = 1,//По факту списания
		[EnumMember(Value = "{\"Ссылка\":\"bbd5e103-83cd-48cf-bafa-fa8775bf4191\", \"Представление\":\"ПоФактуВыпускаПродукции\"}")]
		ПоФактуВыпускаПродукции = 2,//По факту выпуска продукции
	}
	public static partial class ПорядокПризнанияМатериальныхРасходов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоОплатеПоставщику = new Guid("3ee54782-8ce4-2d6f-49f4-11510b332e7c");//По оплате поставщику
		public static readonly Guid ПоФактуСписания = new Guid("7edf6eb1-a6a1-f08d-47b9-78aeef850767");//По факту списания
		public static readonly Guid ПоФактуВыпускаПродукции = new Guid("87fafaba-bf75-9141-48cf-83cdbbd5e103");//По факту выпуска продукции
		public static ПорядокПризнанияМатериальныхРасходов Получить(this ПорядокПризнанияМатериальныхРасходов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПорядокПризнанияМатериальныхРасходов Получить(this ПорядокПризнанияМатериальныхРасходов Значение, Guid Ссылка)
		{
			if(Ссылка == ПоОплатеПоставщику)
			{
				return ПорядокПризнанияМатериальныхРасходов.ПоОплатеПоставщику;
			}
			else if(Ссылка == ПоФактуСписания)
			{
				return ПорядокПризнанияМатериальныхРасходов.ПоФактуСписания;
			}
			else if(Ссылка == ПоФактуВыпускаПродукции)
			{
				return ПорядокПризнанияМатериальныхРасходов.ПоФактуВыпускаПродукции;
			}
			return ПорядокПризнанияМатериальныхРасходов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПорядокПризнанияМатериальныхРасходов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПорядокПризнанияМатериальныхРасходов Значение)
		{
			switch (Значение)
			{
				case ПорядокПризнанияМатериальныхРасходов.ПоОплатеПоставщику: return ПоОплатеПоставщику;
				case ПорядокПризнанияМатериальныхРасходов.ПоФактуСписания: return ПоФактуСписания;
				case ПорядокПризнанияМатериальныхРасходов.ПоФактуВыпускаПродукции: return ПоФактуВыпускаПродукции;
			}
			return Guid.Empty;
		}
	}
}