   M S B A M L   `   `   `  ????G  CPerfumeryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PerfumeryAppPerfumeryApp  5   	       PerfumeryApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PerfumeryApp     5   	     ? Title$  	Perfumery??5   	   $	??450??6   $	??800??6(   .??5	      ]? .+?5
   
   ]? $	??Top=?6   ??.  .+?5      ?? -   5        $??logLabel??5      $?? ??6$   ?? 5      -   5         ??Name$ loginBtn??5   ,   $??Right=?6   $??
Войти??6>   6N   5      ?? 5   
   $??Bottom=?6    ?? Orientation$ 
Horizontal=?6-   $??30??6F   .+?5      ?? -   5        $ 	ordersBtn??5      $??Заказы??6(   {?.  6Q   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ goodsDataGrid??5   (   $	??Top=?6      AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=?6n      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Описание??6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   ?? *Description+  5      $ Категория??6%   	 68   ?? *
Category+  5      $ Скидка??6%   	 65   ?? *
Discount+  5      $ Количество??6%   	 69   ?? *
Quantity+4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      ?? 5      .R?5      ?? $ goodBtn??6%   -   5        $??Подробнее??5   6   6J   5      5      5      5       5!      