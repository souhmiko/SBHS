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
import"../kendo.core.js";!function(e,t){kendo.ui.FlatColorPicker&&(kendo.ui.FlatColorPicker.prototype.options.messages=e.extend(!0,kendo.ui.FlatColorPicker.prototype.options.messages,{apply:"Alkalmaz",cancel:"Mégse",noColor:"nincs szín",clearColor:"Tiszta szín"})),kendo.ui.ColorPicker&&(kendo.ui.ColorPicker.prototype.options.messages=e.extend(!0,kendo.ui.ColorPicker.prototype.options.messages,{apply:"Alkalmaz",cancel:"Mégse",noColor:"nincs szín",clearColor:"Tiszta szín"})),kendo.ui.ColumnMenu&&(kendo.ui.ColumnMenu.prototype.options.messages=e.extend(!0,kendo.ui.ColumnMenu.prototype.options.messages,{sortAscending:"Rendezés növekvő",sortDescending:"Rendezés csökkenő",filter:"Szűrés",columns:"Oszlopok",done:"Kész",settings:"Oszlopbeállítások",lock:"Rögzít",unlock:"Felold"})),kendo.ui.Editor&&(kendo.ui.Editor.prototype.options.messages=e.extend(!0,kendo.ui.Editor.prototype.options.messages,{bold:"Félkövér",italic:"Dőlt",underline:"Aláhúzott",strikethrough:"Áthúzott",superscript:"Felső index",subscript:"Alsó index",justifyCenter:"Középre igazítás",justifyLeft:"Balra igazítás",justifyRight:"Jobbra igazítás",justifyFull:"Sorkizárás",insertUnorderedList:"Számozatlan lista beszúrása",insertOrderedList:"Számozott lista beszúrása",indent:"Behúzás növelése",outdent:"Behúzás csökkentése",createLink:"Hivatkozás beszúrása",unlink:"Hivatkozás eltávolítása",insertImage:"Kép beszúrása",insertFile:"Fájl beszúrása",insertHtml:"HTML beszúrása",viewHtml:"HTML megtekintése",fontName:"Betűtípus választás",fontNameInherit:"(örökölt betűtípus)",fontSize:"Betűméret választás",fontSizeInherit:"(örökölt méret)",formatBlock:"Formátum",formatting:"Formázás",foreColor:"Tintaszín",backColor:"Háttérszín",style:"Stílusok",emptyFolder:"Üres mappa",uploadFile:"Feltöltés",overflowAnchor:"További eszközök",orderBy:"Rendezés:",orderBySize:"Méret",orderByName:"Név",invalidFileType:'A fájl "{0}" nem megfelelő típusú. Támogatott fájltípusok: {1}.',deleteFile:'Biztos, hogy törli a fájlt: "{0}"?',overwriteFile:'A mappában már létezik "{0}" nevű fájl. Kívánja felülírni?',directoryNotFound:"Nincs ilyen nevű könyvtár.",imageWebAddress:"Webcím",imageAltText:"Alternatív szöveg",imageWidth:"Szélesség (px)",imageHeight:"Magasság (px)",fileWebAddress:"Webcím",fileTitle:"Cím",linkWebAddress:"Webcím",linkText:"Szöveg",linkToolTip:"Helyi súgó",linkOpenInNewWindow:"Megnyitás új ablakban",dialogUpdate:"Frissítés",dialogInsert:"Beszúrás",dialogButtonSeparator:"vagy",dialogCancel:"Mégse",cleanFormatting:"Formázás törlése",createTable:"Táblázat létrehozása",addColumnLeft:"Oszlop beszúrása balra",addColumnRight:"Oszlop beszúrása jobbra",addRowAbove:"Sor beszúrása fölé",addRowBelow:"Sor beszúrása alá",deleteRow:"Sor törlése",deleteColumn:"Oszlop törlése",dialogOk:"OK",tableWizard:"Tábla varázsló",tableTab:"Tábla",cellTab:"Cella",accessibilityTab:"Hozzáférhetőség",caption:"Szöveg",summary:"Összegzés",width:"Szélesség",height:"Magasság",units:"Mértékegységek",cellSpacing:"Cella térköz",cellPadding:"Cella párnázás",cellMargin:"Cella margó",alignment:"Igazítás",background:"Háttér",cssClass:"CSS osztály",id:"ID",border:"Szegély",borderStyle:"Szegély stílusa",collapseBorders:"Keretek összeomlasztása",wrapText:"Szövegtörés",associateCellsWithHeaders:"Cellák társítása a fejlécekkel",alignLeft:"Balra igazítás",alignCenter:"Középre igazítás",alignRight:"Jobbra igazítás",alignLeftTop:"Igazítás balra és felülre",alignCenterTop:"Igazítás vízszintesen középre és felülre",alignRightTop:"Igazítás jobbra és felülre",alignLeftMiddle:"Igazítás balra és függőlegesen középre",alignCenterMiddle:"Igazítás vízszintesen és függőlegesen középre",alignRightMiddle:"Igazítás jobbra és függőlegesen középre",alignLeftBottom:"Igazítás balra és alulra",alignCenterBottom:"Igazítás vízszintesen középre és alulra",alignRightBottom:"Igazítás jobbra és alulra",alignRemove:"Igazítás törlése",columns:"Oszlopok",rows:"Sorok",selectAllCells:"Összes cella kiválasztása"})),kendo.ui.FileBrowser&&(kendo.ui.FileBrowser.prototype.options.messages=e.extend(!0,kendo.ui.FileBrowser.prototype.options.messages,{uploadFile:"Feltöltés",orderBy:"Rendezés",orderByName:"Név",orderBySize:"Méret",directoryNotFound:"Nincs ilyen nevű könyvtár.",emptyFolder:"Üres könyvtár",deleteFile:'Biztos, hogy törli a fájlt: "{0}"?',invalidFileType:'A fájl "{0}" nem megfelelő típusú. Támogatott fájltípusok: {1}.',overwriteFile:'A mappában már létezik "{0}" nevű fájl. Kívánja felülírni?',dropFilesHere:"Húzza ide a feltöltendő fájlokat",search:"Keresés"})),kendo.ui.FilterCell&&(kendo.ui.FilterCell.prototype.options.messages=e.extend(!0,kendo.ui.FilterCell.prototype.options.messages,{isTrue:"igaz",isFalse:"hamis",filter:"Szűrés",clear:"Törlés",operator:"Művelet"})),kendo.ui.FilterCell&&(kendo.ui.FilterCell.prototype.options.operators=e.extend(!0,kendo.ui.FilterCell.prototype.options.operators,{string:{eq:"egyenlő",neq:"nem egyenlő",startswith:"kezdődik",contains:"tartalmazza",doesnotcontain:"nem tartalmazza",endswith:"végződik",isnull:"null",isnotnull:"nem null",isempty:"üres",isnotempty:"nem üres",isnullorempty:"nincs értéke",isnotnullorempty:"van értéke"},number:{eq:"egyenlő",neq:"nem egyenlő",gte:"nagyobb vagy egyenlő",gt:"nagyobb",lte:"kisebb vagy egyenlő",lt:"kisebb",isnull:"null",isnotnull:"nem null"},date:{eq:"egyenlő",neq:"nem egyenlő",gte:"utána vagy ekkor",gt:"utána",lte:"előtte vagy ekkor",lt:"előtte",isnull:"null",isnotnull:"nem null"},enums:{eq:"egyenlő",neq:"nem egyenlő",isnull:"null",isnotnull:"nem null"}})),kendo.ui.FilterMenu&&(kendo.ui.FilterMenu.prototype.options.messages=e.extend(!0,kendo.ui.FilterMenu.prototype.options.messages,{info:"Megjelenítendő elemek értéke:",title:"Megjelenítendő elemek értéke",isTrue:"igaz",isFalse:"hamis",filter:"Szűrés",clear:"Törlés",and:"és",or:"vagy",selectValue:"-Válasszon-",operator:"Művelet",value:"Érték",cancel:"Mégse"})),kendo.ui.FilterMenu&&(kendo.ui.FilterMenu.prototype.options.operators=e.extend(!0,kendo.ui.FilterMenu.prototype.options.operators,{string:{eq:"egyenlő",neq:"nem egyenlő",startswith:"kezdődik",contains:"tartalmazza",doesnotcontain:"nem tartalmazza",endswith:"végződik",isnull:"null",isnotnull:"nem null",isempty:"üres",isnotempty:"nem üres",isnullorempty:"nincs értéke",isnotnullorempty:"van értéke"},number:{eq:"egyenlő",neq:"nem egyenlő",gte:"nagyobb vagy egyenlő",gt:"nagyobb",lte:"kisebb vagy egyenlő",lt:"kisebb",isnull:"null",isnotnull:"nem null"},date:{eq:"egyenlő",neq:"nem egyenlő",gte:"utána vagy ekkor",gt:"utána",lte:"előtte vagy ekkor",lt:"előtte",isnull:"null",isnotnull:"nem null"},enums:{eq:"egyenlő",neq:"nem egyenlő",isnull:"null",isnotnull:"nem null"}})),kendo.ui.FilterMultiCheck&&(kendo.ui.FilterMultiCheck.prototype.options.messages=e.extend(!0,kendo.ui.FilterMultiCheck.prototype.options.messages,{checkAll:"Összes kijelölése",clear:"Törlés",filter:"Szűrés",search:"Keresés"})),kendo.ui.Gantt&&(kendo.ui.Gantt.prototype.options.messages=e.extend(!0,kendo.ui.Gantt.prototype.options.messages,{actions:{addChild:"Gyermekelem hozzáadása",append:"Feladat hozzáadása",insertAfter:"Hozzáadás alá",insertBefore:"Hozzáadás fölé",pdf:"Exportálás PDF-be"},cancel:"Mégse",deleteDependencyWindowTitle:"Függőség törlése",deleteTaskWindowTitle:"Feladat törlése",destroy:"Törlés",editor:{assingButton:"Hozzárendelés",editorTitle:"Feladat",end:"Vége",percentComplete:"Befejezés",resources:"Erőforrások",resourcesEditorTitle:"Erőforrások",resourcesHeader:"Erőforrások",start:"Indítás",title:"Cím",unitsHeader:"Mértékegységek"},save:"Mentés",views:{day:"nap",end:"vége",month:"hónap",start:"eleje",week:"hét",year:"év"}})),kendo.ui.Grid&&(kendo.ui.Grid.prototype.options.messages=e.extend(!0,kendo.ui.Grid.prototype.options.messages,{commands:{cancel:"Módosítások elvetése",canceledit:"Mégse",create:"Új elem",destroy:"Törlés",edit:"Szerkesztés",excel:"Exportálás Excel-be",pdf:"Exportálás PDF-be",save:"Módosítások mentése",select:"Választás",update:"Frissítés"},editable:{cancelDelete:"Mégse",confirmation:"Biztos, hogy törli az elemet?",confirmDelete:"Törlés"},noRecords:"Nincsenek elérhető elemek.",expandCollapseColumnHeader:""})),kendo.ui.TreeList&&(kendo.ui.TreeList.prototype.options.messages=e.extend(!0,kendo.ui.TreeList.prototype.options.messages,{noRows:"Nincsenek megjeleníthető elemek",loading:"Betöltés...",requestFailed:"A kérés sikertelen.",retry:"Újra",commands:{edit:"Szerkesztés",update:"Frissítés",canceledit:"Mégse",create:"Új elem",createchild:"Gyermekelem hozzáadása",destroy:"Törlés",excel:"Exportálás Excel-be",pdf:"Exportálás PDF-be"}})),kendo.ui.Groupable&&(kendo.ui.Groupable.prototype.options.messages=e.extend(!0,kendo.ui.Groupable.prototype.options.messages,{empty:"Húzza ide az oszlopfejlécet a csoportosításhoz"})),kendo.ui.NumericTextBox&&(kendo.ui.NumericTextBox.prototype.options=e.extend(!0,kendo.ui.NumericTextBox.prototype.options,{upArrowText:"Érték növelése",downArrowText:"Érték csökkentése"})),kendo.ui.MediaPlayer&&(kendo.ui.MediaPlayer.prototype.options.messages=e.extend(!0,kendo.ui.MediaPlayer.prototype.options.messages,{pause:"Szünet",play:"Lejátszás",mute:"Némítás",unmute:"Némítás feloldása",quality:"Minőség",fullscreen:"Teljes képernyő"})),kendo.ui.Pager&&(kendo.ui.Pager.prototype.options.messages=e.extend(!0,kendo.ui.Pager.prototype.options.messages,{allPages:"Összes",display:"{0}-{1} a(z) {2} elemből",empty:"Nincsenek megjeleníthető elemek",page:"Oldal",of:"a(z) {0}",itemsPerPage:"elem / oldal",first:"Ugrás az első oldalra",previous:"Ugrás az előző oldalra",next:"Ugrás a következő oldalra",last:"Ugrás az utolsó oldalra",refresh:"Frissítés",morePages:"További oldalak"})),kendo.ui.TreeListPager&&(kendo.ui.TreeListPager.prototype.options.messages=e.extend(!0,kendo.ui.TreeListPager.prototype.options.messages,{allPages:"Összes",display:"{0}-{1} a(z) {2} elemből",empty:"Nincsenek megjeleníthető elemek",page:"Oldal",of:"a(z) {0}",itemsPerPage:"elem / oldal",first:"Ugrás az első oldalra",previous:"Ugrás az előző oldalra",next:"Ugrás a következő oldalra",last:"Ugrás az utolsó oldalra",refresh:"Frissítés",morePages:"További oldalak"})),kendo.ui.PivotGrid&&(kendo.ui.PivotGrid.prototype.options.messages=e.extend(!0,kendo.ui.PivotGrid.prototype.options.messages,{measureFields:"Húzza az adatelemeket ide",columnFields:"Húzza az oszlopelemeket ide",rowFields:"Húzza a sorelemeket ide"})),kendo.ui.PivotFieldMenu&&(kendo.ui.PivotFieldMenu.prototype.options.messages=e.extend(!0,kendo.ui.PivotFieldMenu.prototype.options.messages,{info:"Megjelenítendő elemek értéke:",filterFields:"Mezőszűrő",filter:"Szűrés",include:"Mezők befoglalása...",title:"Befoglalandó mezők",clear:"Törlés",ok:"OK",cancel:"Mégse",operators:{contains:"tartalmazza",doesnotcontain:"nem tartalmazza",startswith:"kezdődik",endswith:"végződik",eq:"egyenlő",neq:"nem egyenlő"}})),kendo.ui.RecurrenceEditor&&(kendo.ui.RecurrenceEditor.prototype.options.messages=e.extend(!0,kendo.ui.RecurrenceEditor.prototype.options.messages,{frequencies:{never:"Soha",hourly:"Óránként",daily:"Naponta",weekly:"Hetente",monthly:"Havonta",yearly:"Évente"},hourly:{repeatEvery:"Ismételje minden: ",interval:" óra(k)"},daily:{repeatEvery:"Ismételje minden: ",interval:" nap(ok)"},weekly:{interval:" hét(ek)",repeatEvery:"Ismételje minden: ",repeatOn:"Ismételje: "},monthly:{repeatEvery:"Ismételje minden: ",repeatOn:"Ismételje: ",interval:" hónap(ok)",day:"nap "},yearly:{repeatEvery:"Ismételje minden: ",repeatOn:"Ismételje: ",interval:" év(ek)",of:" a(z) "},end:{label:"Vége:",mobileLabel:"Végződik",never:"Soha",after:"Után ",occurrence:" előfordulás(ok)",on:"Ekkor: "},offsetPositions:{first:"első",second:"második",third:"harmadik",fourth:"negyedik",last:"utolsó"},weekdays:{day:"nap",weekday:"munkanap",weekend:"pihenőnap"}})),kendo.ui.Scheduler&&(kendo.ui.Scheduler.prototype.options.messages=e.extend(!0,kendo.ui.Scheduler.prototype.options.messages,{allDay:"egész nap",date:"Dátum",event:"Esemény",time:"Idő",showFullDay:"Teljes nap mutatása",showWorkDay:"Munkaórák mutatása",today:"Ma",save:"Mentés",cancel:"Mégse",destroy:"Törlés",deleteWindowTitle:"Esemény törlése",ariaSlotLabel:"Kiválasztva {0:t}-tól {1:t}-ig",ariaEventLabel:"{0} {1:D} {2:t}",editable:{confirmation:"Biztos, hogy törölni akarja az eseményt?"},views:{day:"nap",week:"Hét",workWeek:"Munkahét",agenda:"Naptár",month:"Hónap"},recurrenceMessages:{deleteWindowTitle:"Ismétlődő elem törlése",deleteWindowOccurrence:"Alkalom törlése",deleteWindowSeries:"Összes ismétlődés törlése",deleteRecurringConfirmation:"Biztos, hogy törölni akarja ezt az alakalmat?",deleteSeriesConfirmation:"Biztos, hogy törölni akarja az összes ismétlődést?",editWindowTitle:"Ismétlődő elem szerkesztése",editWindowOccurrence:"Alkalom szerkesztése",editWindowSeries:"Összes ismétlődés szerkesztése",deleteRecurring:"Csak ezt az alkalmat szeretné törölni, vagy az összes ismétlődést?",editRecurring:"Csak ezt az alkalmat szeretné szerkeszteni, vagy az összes ismétlődést?"},editor:{title:"Cím",start:"Kezdés",end:"Befejezés",allDayEvent:"Egész napos esemény",description:"Leírás",repeat:"Ismétlődés",timezone:" ",startTimezone:"Kezdés időzónája",endTimezone:"Befejezés időzónája",separateTimezones:"A kezdés és a befejezés időzónája eltérő",timezoneEditorTitle:"Időzónák",timezoneEditorButton:"Időzóna",timezoneTitle:"Időzónák",noTimezone:"Nincs időzóna",editorTitle:"Esemény"}})),kendo.spreadsheet&&kendo.spreadsheet.messages.borderPalette&&(kendo.spreadsheet.messages.borderPalette=e.extend(!0,kendo.spreadsheet.messages.borderPalette,{allBorders:"Minden szegély",insideBorders:"Belső szegélyek",insideHorizontalBorders:"Belső vízszintes szegélyek",insideVerticalBorders:"Belső függőleges szegélyek",outsideBorders:"Külső szegélyek",leftBorder:"Bal szegély",topBorder:"Felső szegély",rightBorder:"Jobb szegély",bottomBorder:"Alsó szegély",noBorders:"Nincs szegély",reset:"Alapértelmezett szín",customColor:"Egyéni szín...",apply:"Alkalmaz",cancel:"Mégse"})),kendo.spreadsheet&&kendo.spreadsheet.messages.dialogs&&(kendo.spreadsheet.messages.dialogs=e.extend(!0,kendo.spreadsheet.messages.dialogs,{apply:"Alkalmaz",save:"Mentés",cancel:"Mégse",remove:"Eltávolítás",retry:"Újra",revert:"Visszaállítás",okText:"OK",formatCellsDialog:{title:"Formázás",categories:{number:"Szám",currency:"Pénznem",date:"Dátum"}},fontFamilyDialog:{title:"Betűtípus"},fontSizeDialog:{title:"Betűméret"},bordersDialog:{title:"Szegélyek"},alignmentDialog:{title:"Igazítás",buttons:{justifyLeft:"Balra igazítás",justifyCenter:"Középre igazítás",justifyRight:"Jobbra igazítás",justifyFull:"Sorkizárás",alignTop:"Függőleges igazítás felülre",alignMiddle:"Függőleges igazítás középre",alignBottom:"Függőleges igazítás alulra"}},mergeDialog:{title:"Cellaegyesítés",buttons:{mergeCells:"Összes egyesítése",mergeHorizontally:"Egyesítés vízszintesen",mergeVertically:"Egyesítés függőlegesen",unmerge:"Szétválasztás"}},freezeDialog:{title:"Ablaktábla rögzítése",buttons:{freezePanes:"Ablaktábla rögzítése",freezeRows:"Sorok rögzítése",freezeColumns:"Oszlopok rögzítése",unfreeze:"Rögzítés feloldása"}},confirmationDialog:{text:"Biztos, hogy törli ezt a munkalapot?",title:"Munkalap törlése"},overflowDialog:{errorMessage:"Nem illeszthető be, mert a másolási és a beillesztési terület nem azonos méretű és alakú."},validationDialog:{title:"Adatellenőrzés",hintMessage:"Kérem, írjon be egy érvényes {0} értéket {1}.",hintTitle:"Ellenőrzés {0}",criteria:{any:"Bármely érték",number:"Szám",text:"Szöveg",date:"Dátum",custom:"Egyéni szabály",list:"Lista"},comparers:{greaterThan:"nagyobb, mint",lessThan:"kisebb, mint",between:"a következők közé esik",notBetween:"nem esik a következők közé",equalTo:"egyenlő",notEqualTo:"nem egyenlő",greaterThanOrEqualTo:"nagyobb vagy egyenlő",lessThanOrEqualTo:"kisebb vagy egyenlő"},comparerMessages:{greaterThan:"nagyobb, mint {0}",lessThan:"kisebb, mint {0}",between:"{0} és {1} közé esik",notBetween:"nem esik {0} és {1} közé",equalTo:"egyenlő {0}",notEqualTo:"nem egyenlő {0}",greaterThanOrEqualTo:"nagyobb vagy egyenlő {0}",lessThanOrEqualTo:"kisebb vagy egyenlő {0}",custom:"megfelel a képletnek: {0}"},labels:{criteria:"Feltétel",comparer:"Összehasonlító",min:"Minimum",max:"Maximum",value:"Érték",start:"Kezdés",end:"Befejezés",onInvalidData:"Érvénytelen adat beírásakor",rejectInput:"Bevitel visszautasítása",showWarning:"Figyelmeztetés megjelenítése",showHint:"Javaslat megjelenítése",hintTitle:"Javaslat címe",hintMessage:"Javaslat szövege",ignoreBlank:"Üres cellák mellőzése"},placeholders:{typeTitle:"Típus cím",typeMessage:"Típus üzenet"}},exportAsDialog:{title:"Exportálás...",labels:{fileName:"Fájlnév",saveAsType:"Fájl típusa",exportArea:"Exportálás",paperSize:"Papírméret",margins:"Margók",orientation:"Tájolás",print:"Nyomtatás",guidelines:"Segédvonalak",center:"Középre",horizontally:"Vízszintesen",vertically:"Függőlegesen"}},modifyMergedDialog:{errorMessage:"Nem lehet módosítani az egyesített cella egy részét."},useKeyboardDialog:{title:"Másolás és beillesztés",errorMessage:"Ezek a műveletek nem érhetők el a menüből. Kérem, használja a következő billentyűkombinációkat:",labels:{forCopy:"másoláshoz",forCut:"kivágáshoz",forPaste:"beillesztéshez"}},unsupportedSelectionDialog:{errorMessage:"A művelet nem hajtható végre többes kijelölésen."}})),kendo.spreadsheet&&kendo.spreadsheet.messages.filterMenu&&(kendo.spreadsheet.messages.filterMenu=e.extend(!0,kendo.spreadsheet.messages.filterMenu,{sortAscending:"Tartomány rendezése A-Z",sortDescending:"Tartomány rendezése Z-A",filterByValue:"Szűrés érték szerint",filterByCondition:"Szűrés feltétel alapján",apply:"Alkalmaz",search:"Keresés",addToCurrent:"Hozzáadás az aktuális kijelöléshez",clear:"Törlés",blanks:"(Üresek)",operatorNone:"Egyik sem",and:"és",or:"vagy",operators:{string:{contains:"A szöveg tartalmazza",doesnotcontain:"A szöveg nem tartalmazza",startswith:"A szöveg eleje",endswith:"A szöveg vége"},date:{eq:"A dátum",neq:"A dátum nem",lt:"Ezen dátum előtt",gt:"Ezen dátum után"},number:{eq:"egyenlő",neq:"nem egyenlő",gte:"nagyobb vagy egyenlő",gt:"nagyobb",lte:"kisebb vagy egyenlő",lt:"kisebb"}}})),kendo.spreadsheet&&kendo.spreadsheet.messages.colorPicker&&(kendo.spreadsheet.messages.colorPicker=e.extend(!0,kendo.spreadsheet.messages.colorPicker,{reset:"Alapértelmezett szín",customColor:"Egyéni szín...",apply:"Alkalmaz",cancel:"Mégse"})),kendo.spreadsheet&&kendo.spreadsheet.messages.toolbar&&(kendo.spreadsheet.messages.toolbar=e.extend(!0,kendo.spreadsheet.messages.toolbar,{addColumnLeft:"Oszlop hozzáadása balra",addColumnRight:"Oszlop hozzáadása jobbra",addRowAbove:"Sor hozzáadása fölé",addRowBelow:"Sor hozzáadása alá",alignment:"Igazítás",alignmentButtons:{justifyLeft:"Balra igazítás",justifyCenter:"Középre igazítás",justifyRight:"Jobbra igazítás",justifyFull:"Sorkizárás",alignTop:"Függőleges igazítás felülre",alignMiddle:"Függőleges igazítás középre",alignBottom:"Függőleges igazítás alulra"},backgroundColor:"Kitöltőszín",bold:"Félkövér",borders:"Szegélyek",colorPicker:{reset:"Alapértelmezett szín",customColor:"Egyéni szín..."},copy:"Másolás",cut:"Kivágás",deleteColumn:"Oszlop törlése",deleteRow:"Sor törlése",excelImport:"Importálás Excel-ből...",filter:"Szűrés",fontFamily:"Betűtípus",fontSize:"Betűméret",format:"Egyéni formátum...",formatTypes:{automatic:"Automatikus",number:"Szám",percent:"Százalék",financial:"Könyvelési",currency:"Pénznem",date:"Dátum",time:"Idő",dateTime:"Dátum-idő",duration:"Időtartam",moreFormats:"Egyéb formátum..."},formatDecreaseDecimal:"Tizedeshelyek csökkentése",formatIncreaseDecimal:"Tizedeshelyek növelése",freeze:"Ablaktábla rögzítése",freezeButtons:{freezePanes:"Ablaktábla rögzítése",freezeRows:"Sorok rögzítése",freezeColumns:"Oszlopok rögzítése",unfreeze:"Rögzítés feloldása"},italic:"Dőlt",merge:"Cellaegyesítés",mergeButtons:{mergeCells:"Összes egyesítése",mergeHorizontally:"Egyesítés vízszintesen",mergeVertically:"Egyesítés függőlegesen",unmerge:"Szétválasztás"},open:"Megnyitás...",paste:"Beillesztés",quickAccess:{redo:"Mégis",undo:"Visszavonás"},saveAs:"Mentés másként...",sortAsc:"Rendezés növekvő",sortDesc:"Rendezés csökkenő",sortButtons:{sortSheetAsc:"Munkalap rendezése A-Z",sortSheetDesc:"Munkalap rendezése Z-A",sortRangeAsc:"Tartomány rendezése A-Z",sortRangeDesc:"Tartomány rendezése Z-A"},textColor:"Tintaszín",textWrap:"Szöveg törése több sorba",underline:"Aláhúzott",validation:"Adatellenőrzés..."})),kendo.spreadsheet&&kendo.spreadsheet.messages.view&&(kendo.spreadsheet.messages.view=e.extend(!0,kendo.spreadsheet.messages.view,{errors:{shiftingNonblankCells:"Adatvesztés nélkül nem lehet a cellákat beszúrni. Válasszon másik beszúrási pozíciót, vagy törölje az adatokat a munkalap végéről.",filterRangeContainingMerges:"Nem lehet szűrőt készíteni összevonásokat tartalmazó tartományon belül",validationError:"A beírt érték megsérti a cellára beállított adatellenőrzési szabályokat.",cannotModifyDisabled:"Nem lehet módosítani a letiltott cellákat."},tabs:{home:"Elejére",insert:"Beszúrás",data:"Adat"}})),kendo.ui.Slider&&(kendo.ui.Slider.prototype.options=e.extend(!0,kendo.ui.Slider.prototype.options,{increaseButtonTitle:"Növelés",decreaseButtonTitle:"Csökkentés"})),kendo.ui.ListBox&&(kendo.ui.ListBox.prototype.options.messages=e.extend(!0,kendo.ui.ListBox.prototype.options.messages,{tools:{remove:"Törlés",moveUp:"Mozgatás felfelé",moveDown:"Mozgatás lefelé",transferTo:"Felvétel",transferFrom:"Eltávolítás",transferAllTo:"Összes felvétele",transferAllFrom:"Összes eltávolítása"}})),kendo.ui.DateTimePicker&&(kendo.ui.DateTimePicker.prototype.options.messages=e.extend(!0,kendo.ui.DateTimePicker.prototype.options.messages,{set:"Beállít",cancel:"Mégse",hour:"Óra",minute:"Perc",second:"Másodperc",milisecond:"Millisec",now:"Most",date:"Dátum",time:"Idő"})),kendo.ui.TreeList&&(kendo.ui.TreeList.prototype.options.messages=e.extend(!0,kendo.ui.TreeList.prototype.options.messages,{noRows:"Nincsenek megjeleníthető elemek",loading:"Betöltés...",requestFailed:"A kérés sikertelen",retry:"Újra",commands:{edit:"Szerkesztés",update:"Frissítés",canceledit:"Mégse",create:"Új elem",createchild:"Gyermekelem hozzáadása",destroy:"Törlés",excel:"Exportálás Excel-be",pdf:"Exportálás PDF-be"}})),kendo.ui.TreeView&&(kendo.ui.TreeView.prototype.options.messages=e.extend(!0,kendo.ui.TreeView.prototype.options.messages,{loading:"Betöltés...",requestFailed:"A kérés sikertelen",retry:"Újra"})),kendo.ui.Upload&&(kendo.ui.Upload.prototype.options.localization=e.extend(!0,kendo.ui.Upload.prototype.options.localization,{select:"Választás...",cancel:"Mégse",retry:"Újra",remove:"Eltávolítás",clearSelectedFiles:"Törlés",uploadSelectedFiles:"Fájlok feltöltése",dropFilesHere:"Húzza ide a feltöltendő fájlokat",statusUploading:"feltöltés",statusUploaded:"feltöltve",statusWarning:"figyelem",statusFailed:"sikertelen",headerStatusUploading:"Feltöltés...",headerStatusUploaded:"Kész",invalidMaxFileSize:"A fájl túl nagy.",invalidMinFileSize:"A fájl túl kicsi.",invalidFileExtension:"A fájltípus nem engedélyezett."})),kendo.ui.Validator&&(kendo.ui.Validator.prototype.options.messages=e.extend(!0,kendo.ui.Validator.prototype.options.messages,{required:"{0} szükséges",pattern:"{0} érvénytelen",min:"{0} nagyobb vagy egyenlő kell hogy legyen, mint {1}",max:"{0} kisebb vagy egyenlő kell hogy legyen, mint {1}",step:"{0} érvénytelen",email:"{0} érvénytelen email",url:"{0} érvénytelen URL",date:"{0} érvénytelen dátum",dateCompare:"A végdátum nagyobb vagy egyenlő kell hogy legyen, mint a kezdődátum"})),kendo.ui.progress&&(kendo.ui.progress.messages=e.extend(!0,kendo.ui.progress.messages,{loading:"Betöltés..."})),kendo.ui.Dialog&&(kendo.ui.Dialog.prototype.options.messages=e.extend(!0,kendo.ui.Dialog.prototype.options.localization,{close:"Bezárás"})),kendo.ui.Calendar&&(kendo.ui.Calendar.prototype.options.messages=e.extend(!0,kendo.ui.Calendar.prototype.options.messages,{weekColumnHeader:"",today:"Ma"})),kendo.ui.Alert&&(kendo.ui.Alert.prototype.options.messages=e.extend(!0,kendo.ui.Alert.prototype.options.localization,{okText:"OK"})),kendo.ui.Confirm&&(kendo.ui.Confirm.prototype.options.messages=e.extend(!0,kendo.ui.Confirm.prototype.options.localization,{okText:"OK",cancel:"Mégse"})),kendo.ui.Prompt&&(kendo.ui.Prompt.prototype.options.messages=e.extend(!0,kendo.ui.Prompt.prototype.options.localization,{okText:"OK",cancel:"Mégse"})),kendo.ui.DateInput&&(kendo.ui.DateInput.prototype.options.messages=e.extend(!0,kendo.ui.DateInput.prototype.options.messages,{year:"év",month:"hónap",day:"nap",weekday:"a hét napja",hour:"órák",minute:"prcek",second:"másodpercek",dayperiod:"DE/DU"}))}(window.kendo.jQuery);
//# sourceMappingURL=kendo.messages.hu-HU.js.map
