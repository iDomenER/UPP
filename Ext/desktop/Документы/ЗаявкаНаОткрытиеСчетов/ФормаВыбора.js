﻿Ext.require(['Данные.Документы.ЗаявкаНаОткрытиеСчетов'], function () 
{
	Ext.define('Документы.ЗаявкаНаОткрытиеСчетов.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаВыбора',
	style: 'position:absolute;width:720px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Заявка на открытие счетов',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			id: 'ДокументСписок',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:704px;height:280px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
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
			Высота:280,
			Ширина:704,
			Верх:33,
			Лево:8,
			height: 280,width: 704,
			columns:
			[
				{
					text:'',
					width:'32',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Дата',
					width:'132',
					dataIndex:'Дата',
					flex:1,
				},
				{
					text:'Номер',
					width:'80',
					dataIndex:'Номер',
					flex:1,
				},
				{
					text:'Организация',
					width:'120',
					dataIndex:'Организация',
					flex:1,
				},
				{
					text:'Сотрудники',
					width:'100',
					dataIndex:'КраткийСоставДокумента',
					flex:1,
				},
				{
					text:'Ответственный',
					width:'120',
					dataIndex:'Ответственный',
					flex:1,
				},
				{
					text:'Обработано в банке',
					width:'100',
					dataIndex:'ОбработаноВБанке',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'220',
					dataIndex:'Комментарий',
					flex:1,
				},
				{
					text:'Банковский счет',
					width:'120',
					dataIndex:'БанковскийСчет',
					flex:1,
				},
				{
					text:'Валюта',
					width:'80',
					dataIndex:'Валюта',
					flex:1,
				},
				{
					text:'№ договора',
					width:'80',
					dataIndex:'НомерДоговора',
					flex:1,
				},
				{
					text:'Текст подтверждения',
					width:'220',
					dataIndex:'ТекстПодтверждения',
					flex:1,
				},
				{
					text:'Вид вклада',
					width:'120',
					dataIndex:'ВидВклада',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ЗаявкаНаОткрытиеСчетов/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'Дата',
					},
					{
						name:'Номер',
					},
					{
						name:'Организация',
					},
					{
						name:'КраткийСоставДокумента',
					},
					{
						name:'Ответственный',
					},
					{
						name:'ОбработаноВБанке',
					},
					{
						name:'Комментарий',
					},
					{
						name:'БанковскийСчет',
					},
					{
						name:'Валюта',
					},
					{
						name:'НомерДоговора',
					},
					{
						name:'ТекстПодтверждения',
					},
					{
						name:'ВидВклада',
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
						var грид = Ext.getCmp('ДокументСписок');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.ЗаявкаНаОткрытиеСчетов.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ЗаявкаНаОткрытиеСчетов.ФормаВыбораСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			id: 'ДействияФормы',
			style: 'position:absolute;left:0px;top:0px;width:720px;height:25px;',
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
			Ширина:720,
			Верх:0,
			Лево:0,
			width: 720,
			height: 25,
			items:
			[
				{
					id:'ДействияФормыВыбрать',
					text:'Выбрать',
					tooltip:'Выбрать значение',
					iconCls:'x-Select',
				},
				'-',
				{
					xtype: 'splitbutton',
					id:'Подменю',
					text:'',
					menu: [
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
				{
					text:'Движения документа по регистрам',
					tooltip:'',
				},
				{
					text:'',
					tooltip:'',
				},
				'-',
				{
					text:'Лицевые счета сотрудников организации',
					tooltip:'Лицевые счета сотрудников организации',
				},
				{
					text:'',
					tooltip:'',
				},
					]
				},
					]
				},
				{
					xtype: 'splitbutton',
					id:'Подменю2',
					text:'',
					menu: [
					]
				},
			]
		},
		],
	}],
	dockedItems:
	[
	],
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
						//ПривязкаГраниц(item, item.ПозицияЭлемента);
						if (item.Групповой)
						{
							var элемент = Ext.getCmp(item.id).items.items[0].items.items;
							for (var i = 0; i < элемент.length; i++ ) 
							{
								var текЭлемент = элемент[i];
								//ПривязкаГраниц(текЭлемент, текЭлемент.ПозицияЭлемента);
							}
						}
					});
				}
				форма.ПервоеОткрытие = false;
			}
		}
	}
	});
});