   M S B A M L   `   `   `  ����   Isotope    Isotope.OptionsWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Isotope - Options��$	��520�� � 
ResizeMode$ NoResize=�$	��480�� � 	Resources  �� 
TargetType �� Property �� Value��%/   '��       �� " ��.���  � ��$
 Left=�.��� .+��� $��0��$��0��$��Stretch=�$��Stretch=�$	��NaN��$	��NaN��$��0,0,0,0q�.@��� $��Editor������ .+��� $��Syntax Highlighting��$
��Left=�$	��Top=�$	��118��$��29���� -    ��Name$ 
syntaxList��$��10q�$
��Left=� �� SelectionMode$ Multiple=�$	��275�� �� View �� .P��� $��Keyword��	 �� Width$		 160��
 �� DisplayMemberBinding
 �� *Word+�� $��Color��$		 100�� �� CellTemplate �� .R��� $��colorBox������ *color+����  �� Color �� *color+�� $��Style��$		 100��
 �� *	fontstyle+��  �� Orientation$ 
Horizontal=�$��Right=�.+��� -   $��Right=�$��	10,0,10,0q�$	��Add���� -   $��0,0,10,0q�$
��Edit���� -   $��Right=�$��Delete��$��0,0,10,0q��� -   $��
Autonomous�� J� 	AllowDrop . ���� .+��� $��Command Manager��$
��Left=�$	��Top=�$	��118��$��29���� -   $ commandList��$ Multiple=�$��	10,0,10,0q�$	��155�� �� .P��� $��Index��$	 50��
 �� *Index+�� $��Command��$		 150��
 �� *Commnd+�� $��Description��$		 230��
 �� *Description+�� $��Sub-Command Manager��$
��Left=�$	��Top=�$��29��$	��157���� -   $ subcommandList��$��
10,0,10,10q�$ Multiple=�$	��155�� �� .P��� $��CSV Row��$	 60��
 �� *Row+�� $��Sub-Command��$		 130��
 �� *Sub+�� $��Parent Command��$		 100��
 �� *parentCommand.Commnd+�� $��Description��$		 200��
 �� *sDescription+�� $ 
Horizontal=�$��Right=�.+��� -   $��Right=�$��0,0,10,0q�$	��Add���� -	   $��0,0,10,0q�$
��Edit���� -
   $��Right=�$��0,0,10,0q�$��Delete���� -   $��Right=�$��0,0,10,0q�$��	Clear All���� -   $��Load .JSON Template��$��Right=�$��0,0,10,0q��� -   $��Export as .JSON��$��Right=�$��0,0,10,0q��� -   $��Aliases�� . ���� -   $ 	aliasList��$��
10,0,10,10q�$ Multiple=�$	��257��$��Center=� �� .P��� $��
Alias Name��$		 200��
 �� *Alias+�� $��
Represents��$		 200��
 �� *Number+�� -   $��	Auto-Load�� . ���� $ 
Horizontal=�$��Right=�$	��426��$��43��.+��� -    ��Name$ use_json_cb��$��17��$��Center=�$��Center=� J� RenderTransformOrigin$ 0.5,0.5&��� -    ��Name$ file_display��$	��282��$��Sample Text��$��28���� -    ��Name$ loadjsonfile��$��75��$��23��$ 0.5,0.5&�$��Center=�$��10,0,0,0q�$��	Load File���� $ 
Horizontal=�$��0��$��0��$��Right=�$��Bottom=�$��82��$��22��$��0,0,10,8q�.+��� -   $
��Save��$��Right=�$��Bottom=�$ 0.5,0.5&��� -   $��Cancel��$��Right=�$��	10,0,10,0q�$��Bottom=�