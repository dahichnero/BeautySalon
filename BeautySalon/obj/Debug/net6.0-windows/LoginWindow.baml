   M S B A M L   `   `   `  ????F  BBeautySalon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BeautySalonBeautySalon  5   	       BeautySalon.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BeautySalon     5   	     ? Title$   Вход в систему??5   	   $	??500??6    $	??500??6-   $??22(?69   $??Tahoma)?6G   .??5	      ?? $??Center=?6   .+?5
   
   ?? $(??"./../Assets/Images/beauty_logo.png??6   $	??200??6<   $	??200??6H   $??0 0 0 25q?5      6$   ?? 5   
   $??PIN-Код:??6   $
??10 0q?6#   $
??Bold"?61   6E   G? 5   
   -   5         G?Name$ pinCodeInput??5      $
??10 0q?6,   ??5      ?? 5       ?? 
TargetType" G?6      MaterialDesignPasswordBox ?? BasedOn# [  61    ?? Triggers 5      ?? 5       ?? Binding 6&   ??  ?? ElementName$ isKioskCheckBox?? ?? Path$ 	IsChecked? ?? Value True6f   .a?5      ?? 	 ?? Property	 ? {?
 ?? Value$
 False??6:   6J   5      5      5      ?? 5   
   -   5         ??Name$ isKioskCheckBox??5      $-??'Войти в режиме киоска??6,   $??10 20q?6L   6]   ?? 5   
   -   5         ?? 	IsDefault$
 True??5      $??50??60   $??22(?6<   $??Вход??6J   $??10q?6Y    ? Cursor$
 Hand??6e   6u   5      5      