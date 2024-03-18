/**
 * Copyright 2024 Progress Software Corporation and/or one of its subsidiaries or affiliates. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
import"../kendo.core.js";!function(e,t){kendo.ui.FileManager&&(kendo.ui.FileManager.prototype.options.messages=e.extend(!0,kendo.ui.FileManager.prototype.options.messages,{toolbar:{createFolder:"Nouveau dossier",upload:"Téléverser",sortDirection:"Ordre de tri",sortDirectionAsc:"Croissant",sortDirectionDesc:"Décroissant",sortField:"Champ de tri",nameField:"Nom",sizeField:"Taille",typeField:"Type",dateModifiedField:"Date de modification",dateCreatedField:"Date de création",listView:"Liste",gridView:"Grille",search:"Rechercher",details:"Détails",detailsChecked:"Oui",detailsUnchecked:"Non",Delete:"Effacer",Rename:"Renommer"},views:{nameField:"Nom",sizeField:"Taille",typeField:"Type",dateModifiedField:"Date de modification",dateCreatedField:"Date de création",items:"éléments"},dialogs:{upload:{title:"Transférer des fichiers",clear:"Vider",done:"Terminé"},moveConfirm:{title:" ",content:"<p class='k-text-center'>Voulez-vous déplacer les fichiers sélectionnés ou les copier?</p>",okText:"Copier",cancel:"Déplacer",close:"Fermer"},deleteConfirm:{title:"Confirmation de l'effacement",content:"<p class='k-text-center'>Voulez-vous vraiment supprimer les fichiers sélectionnés?<br/>Il n'est pas possible d'annuler cette opération.</p>",okText:"Supprimer",cancel:"Annuler",close:"Fermer"},renamePrompt:{title:"Renommer",content:"<p class='k-text-center'>Entrez un nouveau nom de fichier</p>",okText:"Renommer",cancel:"Annuler",close:"Fermer"}},previewPane:{noFileSelected:"Aucun fichier sélectionné",extension:"Type",size:"Taille",created:"Date de création",createdUtc:"Date de création (UTC)",modified:"Date de modification",modifiedUtc:"Date de modification (UTC)",items:"éléments"}})),kendo.ui.FilterCell&&(kendo.ui.FilterCell.prototype.options.operators=e.extend(!0,kendo.ui.FilterCell.prototype.options.operators,{date:{eq:"Est égal à",gte:"Est postérieur ou égal à",gt:"Est postérieur",lte:"Est antérieur ou égal à",lt:"Est antérieur",neq:"N’est pas égal à",isnull:"Est nulle",isnotnull:"N’est pas nulle"},number:{eq:"Est égal à",gte:"Est supérieur ou égal à",gt:"Est supérieur à",lte:"Est inférieur ou égal à",lt:"Est inférieur à",neq:"N’est pas égal à",isnull:"Est nulle",isnotnull:"N’est pas nulle"},string:{endswith:"Se termine par",eq:"Est égal à",neq:"N’est pas égal à",startswith:"Commence par",contains:"Contient",doesnotcontain:"Ne contient pas",isnull:"Est nulle",isnotnull:"N’est pas nulle",isempty:"Est vide",isnotempty:"N’est pas vide"},enums:{eq:"Est égal à",neq:"N’est pas égal à",isnull:"Est nulle",isnotnull:"N’est pas nulle"}})),kendo.ui.FilterMenu&&(kendo.ui.FilterMenu.prototype.options.operators=e.extend(!0,kendo.ui.FilterMenu.prototype.options.operators,{date:{eq:"Est égal à",gte:"Est postérieur ou égal à",gt:"Est postérieur",lte:"Est antérieur ou égal à",lt:"Est antérieur",neq:"N’est pas égal à",isnull:"Est nulle",isnotnull:"N’est pas nulle"},number:{eq:"Est égal à",gte:"Est supérieur ou égal à",gt:"Est supérieur à",lte:"Est inférieur ou égal à",lt:"Est inférieur à",neq:"N’est pas égal à",isnull:"Est nulle",isnotnull:"N’est pas nulle"},string:{endswith:"Se termine par",eq:"Est égal à",neq:"N’est pas égal à",startswith:"Commence par",contains:"Contient",doesnotcontain:"Ne contient pas",isnull:"Est nulle",isnotnull:"N’est pas nulle",isempty:"Est vide",isnotempty:"N’est pas vide"},enums:{eq:"Est égal à",neq:"N’est pas égal à",isnull:"Est nulle",isnotnull:"N’est pas nulle"}})),kendo.ui.ColumnMenu&&(kendo.ui.ColumnMenu.prototype.options.messages=e.extend(!0,kendo.ui.ColumnMenu.prototype.options.messages,{columns:"Colonnes",sortAscending:"Tri croissant",sortDescending:"Tri décroissant",settings:"Paramètres de colonne",done:"Fini",lock:"Bloquer",unlock:"Ouvrir"})),kendo.ui.RecurrenceEditor&&(kendo.ui.RecurrenceEditor.prototype.options.messages=e.extend(!0,kendo.ui.RecurrenceEditor.prototype.options.messages,{daily:{interval:"jour(s)",repeatEvery:"Répéter chaque:"},end:{after:" Après",occurrence:"occurrence(s)",label:"Finir:",never:"Jamais",on:"Sur",mobileLabel:"Ends"},frequencies:{daily:"Une fois par jour",monthly:"Une fois par mois",never:"Jamais",weekly:"Une fois par semaine",yearly:"Une fois par an"},monthly:{day:"Jour",interval:"mois",repeatEvery:"Répéter chaque:",repeatOn:"Répéter l'opération sur:"},offsetPositions:{first:"premier",fourth:"quatrième",last:"dernier",second:"second",third:"troisième"},weekly:{repeatEvery:"Répéter chaque:",repeatOn:"Répéter l'opération sur:",interval:"semaine(s)"},yearly:{of:"de",repeatEvery:"Répéter chaque:",repeatOn:"Répéter l'opération sur:",interval:"année(ans)"},weekdays:{day:"jour",weekday:"jour de la semaine",weekend:"jour de week-end"}})),kendo.ui.Grid&&(kendo.ui.Grid.prototype.options.messages=e.extend(!0,kendo.ui.Grid.prototype.options.messages,{commands:{create:"Insérer",destroy:"Effacer",canceledit:"Annuler",update:"Mettre à jour",edit:"Éditer",excel:"Export to Excel",pdf:"Export to PDF",select:"Sélectionner",cancel:"Annuler les modifications",save:"Enregistrer les modifications",search:"Rechercher..."},editable:{confirmation:"Êtes-vous sûr de vouloir supprimer cet enregistrement?",cancelDelete:"Annuler",confirmDelete:"Effacer"},noRecords:"Aucun enregistrement disponible."})),kendo.ui.Pager&&(kendo.ui.Pager.prototype.options.messages=e.extend(!0,kendo.ui.Pager.prototype.options.messages,{allPages:"Tous",page:"Page",display:"Afficher les items {0} - {1} de {2}",of:"de {0}",empty:"Aucun enregistrement à afficher.",refresh:"Actualiser",first:"Aller à la première page",itemsPerPage:"articles par page",last:"Aller à la dernière page",next:"Aller à la page suivante",previous:"Aller à la page précédente",morePages:"Plusieurs pages"})),kendo.ui.TreeListPager&&(kendo.ui.TreeListPager.prototype.options.messages=e.extend(!0,kendo.ui.TreeListPager.prototype.options.messages,{allPages:"Tous",page:"Page",display:"Afficher les items {0} - {1} de {2}",of:"de {0}",empty:"Aucun enregistrement à afficher.",refresh:"Actualiser",first:"Aller à la première page",itemsPerPage:"articles par page",last:"Aller à la dernière page",next:"Aller à la page suivante",previous:"Aller à la page précédente",morePages:"Plusieurs pages"})),kendo.ui.FilterCell&&(kendo.ui.FilterCell.prototype.options.messages=e.extend(!0,kendo.ui.FilterCell.prototype.options.messages,{filter:"Filtrer",clear:"Effacer filtre",isFalse:"est fausse",isTrue:"est vrai",operator:"Opérateur"})),kendo.ui.FilterMenu&&(kendo.ui.FilterMenu.prototype.options.messages=e.extend(!0,kendo.ui.FilterMenu.prototype.options.messages,{filter:"Filtrer",and:"Et",clear:"Effacer filtre",info:"Afficher les lignes avec la valeur qui",title:"Afficher les lignes avec la valeur qui",selectValue:"-Sélectionner-",isFalse:"est fausse",isTrue:"est vrai",or:"Ou",cancel:"Annuler",operator:"Opérateur",value:"Valeur"})),kendo.ui.FilterMultiCheck&&(kendo.ui.FilterMultiCheck.prototype.options.messages=e.extend(!0,kendo.ui.FilterMultiCheck.prototype.options.messages,{checkAll:"Choisir toutes",clear:"Effacer filtre",filter:"Filtrer",search:"Recherche"})),kendo.ui.Groupable&&(kendo.ui.Groupable.prototype.options.messages=e.extend(!0,kendo.ui.Groupable.prototype.options.messages,{empty:"Faites glisser un en-tête de colonne et déposer ici pour grouper par cette colonne."})),kendo.ui.Editor&&(kendo.ui.Editor.prototype.options.messages=e.extend(!0,kendo.ui.Editor.prototype.options.messages,{bold:"Gras",createLink:"Insérer un lien hypertexte",fontName:"Police",fontNameInherit:"(police héritée)",fontSize:"Taille de police",fontSizeInherit:"(taille héritée)",formatBlock:"Style du paragraphe",indent:"Augmenter le retrait",insertHtml:"Insérer HTML",insertImage:"Insérer image",insertOrderedList:"Liste numérotée",insertUnorderedList:"Liste à puces",italic:"Italique",justifyCenter:"Centrer",justifyFull:"Justifier",justifyLeft:"Aligner le texte à gauche",justifyRight:"Aligner le texte à droite",outdent:"Diminuer le retrait",strikethrough:"Barré",styles:"Styles",subscript:"Subscript",superscript:"Superscript",underline:"Souligné",unlink:"Supprimer le lien hypertexte",deleteFile:'Êtes-vous sûr de vouloir supprimer "{0}"?',directoryNotFound:"Un répertoire avec ce nom n'a pas été trouvé.",emptyFolder:"Vider le dossier",invalidFileType:'Le fichier sélectionné "{0}" n\'est pas valide. Les types de fichiers supportés sont {1}.',orderBy:"Organiser par:",orderByName:"Nom",orderBySize:"Taille",overwriteFile:'Un fichier avec le nom "{0}" existe déjà dans le répertoire courant. Voulez-vous le remplacer?',uploadFile:"Télécharger",backColor:"Couleur de fond",foreColor:"Couleur",dialogButtonSeparator:"Ou",dialogCancel:"Fermer",dialogInsert:"Insérer",imageAltText:"Le texte de remplacement",imageWebAddress:"Adresse Web",imageWidth:"Largeur (px)",imageHeight:"Hauteur (px)",linkOpenInNewWindow:"Ouvrir dans une nouvelle fenêtre",linkText:"Text",linkToolTip:"Info-bulle",linkWebAddress:"Adresse Web",search:"Search",createTable:"Insérer un tableau",addColumnLeft:"Add column on the left",addColumnRight:"Add column on the right",addRowAbove:"Add row above",addRowBelow:"Add row below",deleteColumn:"Supprimer la colonne",deleteRow:"Supprimer ligne",dropFilesHere:"drop files here to upload",formatting:"Format",viewHtml:"View HTML",dialogUpdate:"Update",insertFile:"Insert file",dialogOk:"OK",tableWizard:"Assistant de tableau",tableTab:"Table",cellTab:"Cellule",accessibilityTab:"Accessibilité",caption:"Sous-titre",summary:"Sommaire",width:"Largeur",height:"Hauteur",cellSpacing:"Espacement des cellules",cellPadding:"Rembourrage des cellules",cellMargin:"Marge des cellules",alignment:"Alignement",background:"Fond",cssClass:"CSS Classe",id:"Id",border:"Bordure",borderStyle:"Style de bordure",collapseBorders:"Rétracter bordures",wrapText:"Renvoi à la ligne",associateCellsWithHeaders:"Entêtes associées",alignLeft:"Aligner à gauche",alignCenter:"Aligner le centre",alignRight:"Aligner à droite",alignLeftTop:"Aligner à gauche et haut",alignCenterTop:"Aligner le centre et haut",alignRightTop:"Aligner à droite et haut",alignLeftMiddle:"Aligner à gauche et milieu",alignCenterMiddle:"Aligner le centre et milieu",alignRightMiddle:"Aligner à droite et milieu",alignLeftBottom:"Aligner à gauche et bas",alignCenterBottom:"Aligner le centre et bas",alignRightBottom:"Aligner à droite et bas",alignRemove:"Retirer alignement",columns:"Colonnes",rows:"Lignes",selectAllCells:"Sélectionner toutes les cellules"}));var r={uploadFile:"Charger",orderBy:"Trier par",orderByName:"Nom",orderBySize:"Taille",directoryNotFound:"Aucun répértoire de ce nom.",emptyFolder:"Répertoire vide",deleteFile:'Etes-vous sûr de vouloir supprimer "{0}"?',invalidFileType:'Le fichier sélectionné "{0}" n\'est pas valide. Les type fichiers supportés sont {1}.',overwriteFile:'Un fichier du nom "{0}" existe déjà dans ce répertoire. Voulez-vous le remplacer?',dropFilesHere:"glissez les fichiers ici pour les charger",search:"Recherche"};kendo.ui.FileBrowser&&(kendo.ui.FileBrowser.prototype.options.messages=e.extend(!0,kendo.ui.FileBrowser.prototype.options.messages,r)),kendo.ui.ImageBrowser&&(kendo.ui.ImageBrowser.prototype.options.messages=e.extend(!0,kendo.ui.ImageBrowser.prototype.options.messages,r)),kendo.ui.Upload&&(kendo.ui.Upload.prototype.options.localization=e.extend(!0,kendo.ui.Upload.prototype.options.localization,{cancel:"Annuler",dropFilesHere:"déposer les fichiers à télécharger ici",remove:"Retirer",retry:"Réessayer",select:"Sélectionner...",statusFailed:"échoué",statusUploaded:"téléchargé",statusUploading:"téléchargement",uploadSelectedFiles:"Télécharger des fichiers",headerStatusUploaded:"Done",headerStatusUploading:"Uploading..."})),kendo.ui.Scheduler&&(kendo.ui.Scheduler.prototype.options.messages=e.extend(!0,kendo.ui.Scheduler.prototype.options.messages,{allDay:"toute la journée",cancel:"Annuler",editable:{confirmation:"Etes-vous sûr de vouloir supprimer cet élément?"},date:"Date",destroy:"Effacer",editor:{allDayEvent:"Toute la journée",description:"Description",editorTitle:"Evènement",end:"Fin",endTimezone:"End timezone",repeat:"Répéter",separateTimezones:"Use separate start and end time zones",start:"Début",startTimezone:"Start timezone",timezone:" ",timezoneEditorButton:"Fuseau horaire",timezoneEditorTitle:"Fuseaux horaires",title:"Titre",noTimezone:"Pas de fuseau horaire"},event:"Evènement",recurrenceMessages:{deleteRecurring:"Voulez-vous supprimer seulement cet évènement ou toute la série?",deleteWindowOccurrence:"Suppression de l'élément courant",deleteWindowSeries:"Suppression de toute la série",deleteWindowTitle:"Suppression d'un élément récurrent",editRecurring:"Voulez-vous modifier seulement cet évènement ou toute la série?",editWindowOccurrence:"Modifier l'occurrence courante",editWindowSeries:"Modifier la série",editWindowTitle:"Modification de l'élément courant"},save:"Sauvegarder",time:"Time",today:"Aujourd'hui",views:{agenda:"Agenda",day:"Jour",month:"Mois",week:"Semaine",workWeek:"Semaine de travail",timeline:"Chronologie"},deleteWindowTitle:"Suppression de l'élément",showFullDay:"Montrer toute la journée",showWorkDay:"Montrer les heures ouvrables"})),kendo.ui.Validator&&(kendo.ui.Validator.prototype.options.messages=e.extend(!0,kendo.ui.Validator.prototype.options.messages,{required:"{0} est requis",pattern:"{0} n'est pas valide",min:"{0} doit être plus grand ou égal à {1}",max:"{0} doit être plus petit ou égal à {1}",step:"{0} n'est pas valide",email:"{0} n'est pas un courriel valide",url:"{0} n'est pas une adresse web valide",date:"{0} n'est pas une date valide",dateCompare:"La date de fin doit être postérieure à la date de début"})),kendo.ui.Dialog&&(kendo.ui.Dialog.prototype.options.messages=e.extend(!0,kendo.ui.Dialog.prototype.options.localization,{close:"Fermer"})),kendo.ui.Alert&&(kendo.ui.Alert.prototype.options.messages=e.extend(!0,kendo.ui.Alert.prototype.options.localization,{okText:"OK"})),kendo.ui.Confirm&&(kendo.ui.Confirm.prototype.options.messages=e.extend(!0,kendo.ui.Confirm.prototype.options.localization,{okText:"OK",cancel:"Annuler"})),kendo.ui.Prompt&&(kendo.ui.Prompt.prototype.options.messages=e.extend(!0,kendo.ui.Prompt.prototype.options.localization,{okText:"OK",cancel:"Annuler"})),kendo.ui.FlatColorPicker&&(kendo.ui.FlatColorPicker.prototype.options.messages=e.extend(!0,kendo.ui.FlatColorPicker.prototype.options.messages,{apply:"Appliquer",cancel:"Annuler",noColor:"aucune couleur",clearColor:"Supprimer la couleur"})),kendo.ui.ColorPicker&&(kendo.ui.ColorPicker.prototype.options.messages=e.extend(!0,kendo.ui.ColorPicker.prototype.options.messages,{apply:"Appliquer",cancel:"Annuler",noColor:"aucune couleur",clearColor:"Supprimer la couleur"})),kendo.ui.NumericTextBox&&(kendo.ui.NumericTextBox.prototype.options=e.extend(!0,kendo.ui.NumericTextBox.prototype.options,{upArrowText:"Augmenter la valeur",downArrowText:"Diminuer la valeur"}))}(window.kendo.jQuery);
//# sourceMappingURL=kendo.messages.fr-CD.js.map
