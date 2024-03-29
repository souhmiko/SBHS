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
import"./kendo.core.js";var __meta__={id:"floatinglabel",name:"FloatingLabel",category:"framework",depends:["core"],hidden:!0};!function(e,t){var n=window.kendo,o=n.ui.Widget,i=n.ui,l=".kendoFloatingLabel",s="k-empty",a="k-focus",d="k-disabled",r="k-no-click",p="k-readonly",f=o.extend({init:function(i,l){var s=this;o.fn.init.call(s,i,l),l=e.extend(!0,{},l),s.widget=s.options.widget,s.widgetWrapper=s.widget.wrapper[0],s.refresh(),s._editable({readonly:s.options.widget.options.readonly!==t&&s.options.widget.options.readonly,disable:s.options.widget.options.enable!==t&&!s.options.widget.options.enable}),s.widgetWrapper.style.width&&(s.element.css("width",s.widgetWrapper.style.width),s.widgetWrapper.style.width="100%"),s.element.addClass("k-floating-label-container"),n.notify(s)},options:{name:"FloatingLabel",widget:null,useReadOnlyClass:!1,floatCheck:({element:e})=>!e.val()},readonly:function(e){this._editable({readonly:e===t||e,disable:!1})},enable:function(e){this._editable({readonly:!1,disable:!(e=e===t||e)})},refresh:function(){var e=this,t=e.element,n=e.options.widget.wrapper.find(".k-input-inner");if(n.length>0){var o=e.element.find("> .k-input-label").height(),i=n.position().left+Number.parseInt(n.css("padding-left")),l=n.position().top+Number.parseInt(n.css("padding-top"))+o;t[0].style.setProperty("--kendo-floating-label-offset-x",i+"px"),t[0].style.setProperty("--kendo-floating-label-offset-y",l+"px")}t.removeClass(s).removeClass(a),e.options.floatCheck({element:e.options.widget.element,floating:e.element})&&t.addClass(s),(document.activeElement===e.options.widget.element[0]||e.options.widget.input&&document.activeElement===e.options.widget.input[0])&&t.addClass(a)},destroy:function(){this.element.off(l),o.fn.destroy.call(this)},_editable:function(e){var t=this,n=t.element,o=e.disable,i=e.readonly;n.off(l),i||o?n.toggleClass(d,o).toggleClass(t.options.useReadOnlyClass?p:r,i):(n.removeClass(d).removeClass(t.options.useReadOnlyClass?p:r),n.on("focusin"+l,t.refresh.bind(t)),n.on("focusout"+l,t.refresh.bind(t)))}});i.plugin(f)}(window.kendo.jQuery);var kendo$1=kendo;export{kendo$1 as default};
//# sourceMappingURL=kendo.floatinglabel.js.map
