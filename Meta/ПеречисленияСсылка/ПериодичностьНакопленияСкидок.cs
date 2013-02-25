﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ПериодичностьНакопленияСкидок
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"45e5e7b5-0304-48d7-87ce-bd385a38e2a7\", \"Представление\":\"Месяц\"}")]
		Месяц = 0,
		[EnumMember(Value = "{\"Ссылка\":\"2f74c607-b277-4ff0-96c6-2cc878841043\", \"Представление\":\"Квартал\"}")]
		Квартал = 1,
		[EnumMember(Value = "{\"Ссылка\":\"4fcda70e-99e2-4283-8b78-7990242a72f1\", \"Представление\":\"Полугодие\"}")]
		Полугодие = 2,
		[EnumMember(Value = "{\"Ссылка\":\"c861442f-a976-482e-b64c-36406fe908a3\", \"Представление\":\"Год\"}")]
		Год = 3,
		[EnumMember(Value = "{\"Ссылка\":\"2cbc1de6-c6ad-4b81-9605-8cf6cc3c0a0d\", \"Представление\":\"ВТечениеВсегоПериода\"}")]
		ВТечениеВсегоПериода = 4,//В течение всего периода
	}
	public static partial class ПериодичностьНакопленияСкидок_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Месяц = new Guid("38bdce87-385a-a7e2-48d7-030445e5e7b5");
		public static readonly Guid Квартал = new Guid("c82cc696-8478-4310-4ff0-b2772f74c607");
		public static readonly Guid Полугодие = new Guid("9079788b-2a24-f172-4283-99e24fcda70e");
		public static readonly Guid Год = new Guid("40364cb6-e96f-a308-482e-a976c861442f");
		public static readonly Guid ВТечениеВсегоПериода = new Guid("f68c0596-3ccc-0d0a-4b81-c6ad2cbc1de6");//В течение всего периода
		public static ПериодичностьНакопленияСкидок Получить(this ПериодичностьНакопленияСкидок Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПериодичностьНакопленияСкидок Получить(this ПериодичностьНакопленияСкидок Значение, Guid Ссылка)
		{
			if(Ссылка == Месяц)
			{
				return ПериодичностьНакопленияСкидок.Месяц;
			}
			else if(Ссылка == Квартал)
			{
				return ПериодичностьНакопленияСкидок.Квартал;
			}
			else if(Ссылка == Полугодие)
			{
				return ПериодичностьНакопленияСкидок.Полугодие;
			}
			else if(Ссылка == Год)
			{
				return ПериодичностьНакопленияСкидок.Год;
			}
			else if(Ссылка == ВТечениеВсегоПериода)
			{
				return ПериодичностьНакопленияСкидок.ВТечениеВсегоПериода;
			}
			return ПериодичностьНакопленияСкидок.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПериодичностьНакопленияСкидок Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПериодичностьНакопленияСкидок Значение)
		{
			switch (Значение)
			{
				case ПериодичностьНакопленияСкидок.Месяц: return Месяц;
				case ПериодичностьНакопленияСкидок.Квартал: return Квартал;
				case ПериодичностьНакопленияСкидок.Полугодие: return Полугодие;
				case ПериодичностьНакопленияСкидок.Год: return Год;
				case ПериодичностьНакопленияСкидок.ВТечениеВсегоПериода: return ВТечениеВсегоПериода;
			}
			return Guid.Empty;
		}
	}
}