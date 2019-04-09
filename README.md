# web.model.maker
Help to build HTML static interface

Présentation TemplateDesigner

Cette application en ligne de commande permet de générer les maquettes (extention .htm) d’un site web.
Lors de la réalisation de maquette non dynamique, les designers non pas la notion de « MasterPage ». S’ils veulent la modifier, ils se trouvent obligé de modifier chaque page html.
Le designer va réaliser des templates String Template v4 (www.stringtemplate.org). Exemple :
•	Views\Home\index.stg
•	Views\Contact\index.stg
•	Views\Shared\master.stg
Il va executé l’application avec un argument :
•	Chemin d’un répertoire parent d’ou se trouve les fichiers
•	Si aucun argument n’est utilisé, le répertoire courant de l’application est utilisé
Les fichier générés seront :
•	Views\Home\index.htm
•	Views\Contact\index. htm
•	Views\Shared\master. htm

Attention : Le symbole $ étant le symbole configuré pour les variable String Template, pour réaliser une variable JQuery, il faut réalisé un double $$.
 
Page de résultat

Avantages :
•	Le designer peut appliquer des modifications à l’ensemble des page d’un seul coups.
•	Le designer peut réaliser des bout de code html qu’il peut ré-utiliser et modifier facielement.
•	La maquette est déjà prédécoupé pour les développeur

Note : Il existe un plugin VS2010 StringTemplate qui ajoute la coloration syntaxique aux Templates.
http://visualstudiogallery.msdn.microsoft.com/5ca30e58-96b4-4edf-b95e-3030daf474ff


# Présentation TemplateDesigner

Cette application en ligne de commande permet de générer les maquettes (extention .htm) d’un site web.
Lors de la réalisation de maquette non dynamique, les designers non pas la notion de « MasterPage ». S’ils veulent la modifier, ils se trouvent obligé de modifier chaque page html.
Le designer va réaliser des templates String Template v4 (www.stringtemplate.org). Exemple :
•	Views\Home\index.stg
•	Views\Contact\index.stg
•	Views\Shared\master.stg
Il va executé l’application avec un argument :
•	Chemin d’un répertoire parent d’ou se trouve les fichiers
•	Si aucun argument n’est utilisé, le répertoire courant de l’application est utilisé
Les fichier générés seront :
•	Views\Home\index.htm
•	Views\Contact\index. htm
•	Views\Shared\master. htm

Attention : Le symbole $ étant le symbole configuré pour les variable String Template, pour réaliser une variable JQuery, il faut réalisé un double $$.
