   M S B A M L   `   `   `  ????F  BBeautySalon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BeautySalon.ViewsBeautySalon.Views  5          BeautySalon.Views.ZapPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:BeautySalon.Views     5      -   5          N?Name$  zapPage??5	   a    N? Title$ ZapPage??6    ? DataContext 6   ??  ?? Mode$ OneWay=? ?? RelativeSource ?? *Self+.??5      ]? .+?5   
   ?? $	??Top=?6   $??35(?6%   $
??Bold"?63   $??Записи??6E   $??0 0 0 25q?6V   6j   ?? 5   
   -   5         ??Name$ colors??5   p   $??Disabled=?6:   ??6   ?? *ClientServices+??5      ?? 5      .R?5      ? $	??800??6   ??6'   ??  ?? ElementName$
 what?? ?? Path$
 Text?   backgroundTime ?? 	Converter# [  	 ? ColumnDefinitions	 5      ?? 5      $	??800 ?6/   .+?5      ?? $??7q?6%   $??0??60   .+?5      ?? $??22(?6(   $
??Wrap=?66   Услуга: ?? 5      $??14(?6=   $
??Bold"?6K   ?6   ?? *Service.Title+6K   ?? 5      Клиент: ?? 5      $??14(?6@   $
??Bold"?6N   ?6   ?? *Client.FirstName+6N    ?? 5   "   $??14(?6G   $
??Bold"?6U   ?6&   ?? *Client.LastName+6U    ?? 5   "   $??14(?6I   $
??Bold"?6W   ?6&   ?? *Client.Patronymic+6W   ?? 5   "   Данные клиента: ?? 5   "   $??14(?6D   $??Light"?6R   ?6&   ?? *Client.Email+6R    ?? 5    "   $??14(?6D   $??Light"?6R   ?6&   ?? *Client.Phone+6R   ?? 5!   "   '%Дата и время сеанса: ?? 5#   "   $??14(?6A   $??Medium"?6O   ?6&   ?? *	StartTime+6O   ?? 5$   "   &$Осталось до сеанса: ?? 5&      
 ??Name$
 times??6   $??14(?6T   $
??Bold"?6b   ?6-   ?? *	OstTime+$ OneTime=?6b    часов ?? 5'   "   $??14(?6P   $
??Bold"?6^   ?6&   ?? *
OstTimeMin+$ OneTime=?6^    минут ?? 5(   "   $

 what??6&   $??14(?6^   ?64   ?? *
OstTimeDay+$ OneTime=?6n   ?? 5)   "   5*      5+      5,      5-      ??5/      ?? 50      .R?51      ? 52      54      55      56      