﻿Ext.require(['Данные.Обработки.НаборПерсонала'], function () 
{
	Ext.define('Обработки.НаборПерсонала.Форма',
	{
	extend: 'Ext.window.Window',
	id: 'Форма',
	style: 'position:absolute;width:925px;height:580px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Набор персонала',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			xtype: 'toolbar',
			id: ДействияФормы,
			style: 'position:absolute;left:0px;top:0px;width:878px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Левая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ДействияФормы', Граница: 'Верхняя', Номер: 2, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:25,
			Ширина:878,
			Верх:0,
			Лево:0,
			width: 878,
			height: 25,
			items:
			[
				{
					xtype: 'splitbutton',
					id:'Подменю',
					text:'Действия',
					menu: [
				'-',
				{
					text:'Кадровое планирование...',
					tooltip:'Открыть кадровое планирование',
				},
				{
					text:'Вакансии...',
					tooltip:'',
				},
				{
					text:'Источники информации...',
					tooltip:'Перейти к источникам информации',
				},
				{
					text:'Состояния кандидатов...',
					tooltip:'Состояния кандидатов',
				},
				'-',
				{
					text:'Закрыть',
					tooltip:'Закрыть',
					iconCls:'x-Close',
				},
					]
				},
				'-',
				'-',
				{
					id:'КадровоеПланирование',
					text:'Кадровое планирование...',
					tooltip:'Открыть кадровое планирование',
				},
				'-',
				{
					id:'Вакансии',
					text:'Вакансии...',
					tooltip:'',
				},
				'-',
				{
					id:'ИсточникиИнформации',
					text:'Источники информации...',
					tooltip:'Перейти к источникам информации',
				},
				'-',
				{
					id:'Состояния',
					text:'Состояния кандидатов...',
					tooltip:'Состояния кандидатов',
				},
				'-',
				{
					id:'Действие',
					text:'Справка',
					tooltip:'Открыть справку',
				},
			]
		},
		{
			xtype: 'panel',
			id: ПанельСправкиФормы,
			style: 'position:absolute;left:703px;top:33px;width:214px;height:539px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 37, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:539,
			Ширина:214,
			Верх:33,
			Лево:703,
			height: 539,width: 214,
			tabBar:{hidden:true},
			items:
			[
				{
					id: Страница1,
				},
			]
		},
		{
			xtype: 'panel',
			id: ОсновнаяПанель,
			style: 'position:absolute;left:8px;top:33px;width:689px;height:539px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 37, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:539,
			Ширина:689,
			Верх:33,
			Лево:8,
			height: 539,width: 689,
			tabBar:{hidden:true},
			items:
			[
				{
					id: Страница1,
					items:
					[
		{
			xtype: 'panel',
			id: ПанельНеразобранныеПисьма,
			style: 'position:absolute;left:0px;top:24px;width:689px;height:159px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Верхняя', Номер: 48, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:159,
			Ширина:689,
			Верх:24,
			Лево:0,
			height: 159,width: 689,
			tabBar:{hidden:true},
			items:
			[
				{
					id: Страница1,
					items:
					[
		{
			id: 'ТабличноеПолеНеразобранныеПисьма',
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:31px;width:275px;height:128px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 50, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:128,
			Ширина:275,
			Верх:31,
			Лево:0,
			height: 128,width: 275,
			columns:
			[
				{
					text:'Тема',
					width:'172',
					dataIndex:'Тема',
					flex:1,
				},
				{
					text:'Отправитель',
					width:'99',
					dataIndex:'Отправитель',
					flex:1,
				},
				{
					text:'Ссылка',
					width:'27',
					dataIndex:'Ссылка',
					flex:1,
				},
				{
					text:'Не рассмотрено',
					width:'100',
					dataIndex:'НеРассмотрено',
					flex:1,
				},
				{
					text:'Рассмотреть после',
					width:'100',
					dataIndex:'РассмотретьПосле',
					flex:1,
				},
				{
					text:'Статус письма',
					width:'100',
					dataIndex:'СтатусПисьма',
					flex:1,
				},
				{
					text:'Значение группировки',
					width:'100',
					dataIndex:'ЗначениеГруппировки',
					flex:1,
				},
				{
					text:'Отправитель адрес электронной почты',
					width:'100',
					dataIndex:'ОтправительАдресЭлектроннойПочты',
					flex:1,
				},
				{
					text:'Дата получения',
					width:'100',
					dataIndex:'ДатаПолучения',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/НаборПерсонала/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Тема',
					},
					{
						name:'Отправитель',
					},
					{
						name:'Ссылка',
					},
					{
						name:'НеРассмотрено',
					},
					{
						name:'РассмотретьПосле',
					},
					{
						name:'СтатусПисьма',
					},
					{
						name:'ЗначениеГруппировки',
					},
					{
						name:'ОтправительАдресЭлектроннойПочты',
					},
					{
						name:'ДатаПолучения',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ТабличноеПолеНеразобранныеПисьма');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.НаборПерсонала.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.НаборПерсонала.ФормаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			id: КоманднаяПанельНеразобранныеПисьма,
			style: 'position:absolute;left:0px;top:0px;width:609px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельНеразобранныеПисьма', Граница: 'Верхняя', Номер: 20, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:609,
			Верх:0,
			Лево:0,
			width: 609,
			height: 24,
			items:
			[
				{
					id:'ПринятьКакЗаявку',
					text:'Принять как кандидата...',
					tooltip:'Принять как кандидата',
				},
				{
					id:'ПривязатьКСуществующейЗаявке',
					text:'Привязать к существующему кандидату',
					tooltip:'Привязать к существующему кандидату',
				},
				'-',
				{
					id:'ОткрытьПисьмо',
					text:'Открыть...',
					tooltip:'',
				},
				{
					id:'ПометитьКакПрочтенное',
					text:'Пометить как прочтенное',
					tooltip:'Пометить письмо как прочтенное',
				},
				'-',
				{
					id:'НежелательнаяПочта',
					text:'Переместить в нежелательную почту',
					tooltip:'',
				},
			]
		},
		{
			xtype: 'toolbar',
			id: КоманднаяПанельВсеПисьма,
			style: 'position:absolute;left:609px;top:0px;width:80px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'КоманднаяПанельВсеПисьма', Граница: 'Левая', Номер: 22, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельВсеПисьма', Граница: 'Верхняя', Номер: 22, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:80,
			Верх:0,
			Лево:609,
			width: 80,
			height: 24,
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					id:'Действие',
					text:'Все письма...',
					tooltip:'',
				},
			]
		},
		{
			xtype: 'label',
			id: 'НадписьИнформацияОПисьме',
			text: 'С данным отправителем ранее уже велась переписка',
			style: 'position:absolute;left:302px;top:31px;width:180px;height:33px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'НадписьИнформацияОПисьме', Граница: 'Левая', Номер: 53, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 50, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'НадписьИнформацияОПисьме', Граница: 'Верхняя', Номер: 53, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:33,
			Ширина:180,
			Верх:31,
			Лево:302,
		},
					]
				},
			]
		},
		{
			xtype: 'panel',
			id: РабочаяОбласть,
			style: 'position:absolute;left:0px;top:191px;width:689px;height:348px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 48, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:348,
			Ширина:689,
			Верх:191,
			Лево:0,
			height: 348,width: 689,
			tabBar:{hidden:true},
			items:
			[
				{
					id: Страница1,
					items:
					[
		{
			id: 'ТабличноеПолеЗаявкиКандидатов',
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:53px;width:229px;height:295px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 39, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:295,
			Ширина:229,
			Верх:53,
			Лево:0,
			height: 295,width: 229,
			columns:
			[
				{
					text:'Представление',
					width:'100',
					dataIndex:'Представление',
					flex:1,
				},
				{
					text:'Ссылка',
					width:'100',
					dataIndex:'Ссылка',
					flex:1,
				},
				{
					text:'Значение группировки',
					width:'100',
					dataIndex:'ЗначениеГруппировки',
					flex:1,
				},
				{
					text:'Количество',
					width:'100',
					dataIndex:'Количество',
					flex:1,
				},
				{
					text:'Наименование',
					width:'100',
					dataIndex:'Наименование1',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/НаборПерсонала/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Представление',
					},
					{
						name:'Ссылка',
					},
					{
						name:'ЗначениеГруппировки',
					},
					{
						name:'Количество',
					},
					{
						name:'Наименование1',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ТабличноеПолеЗаявкиКандидатов');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.НаборПерсонала.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.НаборПерсонала.ФормаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			id: КоманднаяПанельЗаявкиКандидатов,
			style: 'position:absolute;left:0px;top:25px;width:596px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельЗаявкиКандидатов', Граница: 'Верхняя', Номер: 21, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:596,
			Верх:25,
			Лево:0,
			width: 596,
			height: 24,
			items:
			[
				'-',
			]
		},
		{
			xtype: 'toolbar',
			id: КоманднаяПанельВсеЗаявки,
			style: 'position:absolute;left:588px;top:25px;width:101px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'КоманднаяПанельВсеЗаявки', Граница: 'Левая', Номер: 23, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельВсеЗаявки', Граница: 'Верхняя', Номер: 23, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:101,
			Верх:25,
			Лево:588,
			width: 101,
			height: 24,
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					id:'ВсеЗаявки',
					text:'Все кандидаты...',
					tooltip:'',
				},
			]
		},
		{
			id: 'ТабличноеПолеПерепискаПоЗаявке',
			xtype: 'grid',
			style: 'position:absolute;left:235px;top:268px;width:146px;height:80px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Левая', Номер: 38, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 39, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 47, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:80,
			Ширина:146,
			Верх:268,
			Лево:235,
			height: 80,width: 146,
			columns:
			[
				{
					text:'Есть вложения',
					width:'21',
					dataIndex:'ЕстьВложения',
					flex:1,
				},
				{
					text:'От кого',
					width:'100',
					dataIndex:'ОтправительПредставление',
					flex:1,
				},
				{
					text:'Кому',
					width:'100',
					dataIndex:'КомуПредставление',
					flex:1,
				},
				{
					text:'Дата отправления',
					width:'140',
					dataIndex:'ДатаОтправления',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/НаборПерсонала/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'ЕстьВложения',
					},
					{
						name:'ОтправительПредставление',
					},
					{
						name:'КомуПредставление',
					},
					{
						name:'ДатаОтправления',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ТабличноеПолеПерепискаПоЗаявке');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.НаборПерсонала.ФормаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.НаборПерсонала.ФормаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			id: КонтекстноеМенюПерепискаПоЗаявке,
			style: 'position:absolute;left:264px;top:212px;width:342px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 39, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 80, Координата: 0},
					Нижняя: { Элемент: 'КонтекстноеМенюПерепискаПоЗаявке', Граница: 'Верхняя', Номер: 52, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:342,
			Верх:212,
			Лево:264,
			width: 342,
			height: 24,
			items:
			[
				{
					id:'Ответить',
					text:'Ответить',
					tooltip:'4b931fc-b705-43e2-b699-4bcd6e2e358',
				},
				'-',
				{
					id:'НовоеПисьмо',
					text:'Новое письмо',
					tooltip:'1dca758-40b5-44aa-9d7e-41bce90c956',
				},
				{
					id:'СкопироватьПисьмо',
					text:'Скопировать письмо',
					tooltip:'d316596-de67-4f9e-8621-c7f43aa3ed6',
				},
				{
					id:'ИзменитьПисьмо',
					text:'Изменить письмо',
					tooltip:'4c0b1b7-09ec-4138-8063-3581a4e2bc6',
				},
				{
					id:'УдалитьПисьмо',
					text:'Установить пометку удаления',
					tooltip:'Установить пометку удаления',
				},
				'-',
				{
					id:'ОтветитьВсем',
					text:'Ответить всем',
					tooltip:'2ba5b96-7217-4141-be49-d960b731689',
				},
				{
					id:'Переслать',
					text:'Переслать',
					tooltip:'b8d4612-8267-4d7f-9f49-2e78b431b8a',
				},
				'-',
				{
					id:'УстановитьРассмотрено',
					text:'Установить """"Рассмотрено""""',
					tooltip:'Установить """"Рассмотрено""""',
				},
				{
					id:'УстановитьНеРассмотрено',
					text:'Установить """"Не рассмотрено""""',
					tooltip:'Установить """"Не рассмотрено""""',
				},
			]
		},
		{
			xtype: 'panel',
			id: ПанельДополнительныеСведения,
			style: 'position:absolute;left:235px;top:68px;width:454px;height:96px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Правая', Номер: 39, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ПанельДополнительныеСведения', Граница: 'Верхняя', Номер: 80, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:96,
			Ширина:454,
			Верх:68,
			Лево:235,
			height: 96,width: 454,
			tabBar:{hidden:true},
			items:
			[
				{
					id: Страница1,
				},
			]
		},
					]
				},
			]
		},
					]
				},
			]
		},
		{
			xtype: 'toolbar',
			id: КоманднаяПанельСправкиФормы,
			style: 'position:absolute;left:878px;top:0px;width:47px;height:25px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельСправкиФормы', Граница: 'Верхняя', Номер: 49, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:25,
			Ширина:47,
			Верх:0,
			Лево:878,
			width: 47,
			height: 25,
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					id:'ПереключениеСправкиФормы',
					text:'Переключить видимость справки формы',
					tooltip:'f5b2958-2b60-4b7b-9357-9683d512666',
				},
			]
		},
		],
	}],
	dockedItems:
	[
	]
	});
	listeners:
	{
		resize:
		{
			fn: function (win, width, height, opt)
			{
				var форма = win.down('form');
				if (!форма.ПервоеОткрытие)
				{
					форма.items.each(function (item)
					{
					ПривязкаГраниц(item, item.ПозицияЭлемента);
					if (item.Групповой)
					{
						var элемент = Ext.getCmp(item.id).items.items[0].items.items;
						for (i = 0; i <= элемент.length -1; i += 1) 
						{
							var текЭлемент = элемент[i];
							ПривязкаГраниц(текЭлемент, текЭлемент.ПозицияЭлемента);
						}
					}
					});
				}
			}
		}
	}
});