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
import"./kendo.core.js";var __meta__={id:"html.base",name:"Html.Base",category:"web",description:"",depends:["core"],features:[]};!function(e,t){var a=window.kendo,s=a.Class;a.html=a.html||{};var n=s.extend({init:function(t,a){this.element=e(t),delete(a=a||{}).name,this._initOptions(a)},options:{stylingOptions:[]},_addClasses:function(){var e=this,t=e.options,s=t.stylingOptions,n=e.wrapper.data("added-classes");s=s.map((function(e){var s;return"themeColor"!==e||(s=a.cssProperties.getValidClass({widget:t.name,propName:"fillMode",value:t.fillMode}))&&0!==s.length?a.cssProperties.getValidClass({widget:t.name,propName:e,value:t[e],fill:t.fillMode}):""})),n&&e.wrapper.removeClass(n.join(" ")),e.wrapper.data("added-classes",s),e.wrapper.addClass(s.join(" "))},html:function(){return this.wrapper[0].outerHTML}});e.extend(a.html,{HTMLBase:n})}(window.kendo.jQuery);var kendo$1=kendo;export{kendo$1 as default};
//# sourceMappingURL=kendo.html.base.js.map
