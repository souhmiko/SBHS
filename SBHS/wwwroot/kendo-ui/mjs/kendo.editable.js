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
import"./kendo.dropdownlist.js";import"./kendo.datepicker.js";import"./kendo.numerictextbox.js";import"./kendo.validator.js";import"./kendo.binder.js";import"./kendo.icons.js";var __meta__={id:"editable",name:"Editable",category:"framework",depends:["checkbox","dropdownlist","datepicker","numerictextbox","validator","binder","icons"],hidden:!0};!function(e,t){var i=window.kendo,o=i.ui,a=o.Widget,n=e.extend,r=i.isFunction,d=e.isPlainObject,l=e.inArray,s=/("|\%|'|\[|\]|\$|\.|\,|\:|\;|\+|\*|\&|\!|\#|\(|\)|<|>|\=|\?|\@|\^|\{|\}|\~|\/|\||`)/g,p="change",u="equalSet",c=["url","email","number","date","boolean"];function v(e){return(e=null!=e?e:"").type||i.type(e)||"string"}function f(e){var t,o,a=(e.model.fields||e.model)[e.field],n=v(a),s=a?a.validation:{},p=a?a.attributes:{},u=i.attr("type"),f=i.attr("bind"),m={id:e.id||e.field,name:e.field,title:e.title?e.title:e.field};for(t in s){if(o=s[t],l(t,c)>=0)m[u]=t;else if(!r(o)){var k=i.getCulture();if("number"==typeof o&&k.name.length){var b=k.numberFormat,x=o.toString().replace(".",b["."]);m[t]=x}else m[t]=d(o)?o.value||t:o}m[i.attr(t+"-msg")]=o.message,m.autocomplete="off"}for(var h in p)m[h]=p[h];return l(n,c)>=0&&(m[u]=n),m[f]=("boolean"===n?"checked:":"value:")+e.field,m}function m(e,t){var i=e.attr("id");return i&&(t.id=i,e.removeAttr("id")),t}var k=["AutoComplete","CheckBox","CheckBoxGroup","ColorGradient","ColorPicker","ColorPalette","ComboBox","DateInput","DatePicker","DateTimePicker","DropDownTree","Editor","FlatColorPicker","MaskedTextBox","MultiColumnComboBox","MultiSelect","NumericTextBox","RadioGroup","Rating","Slider","Switch","TimePicker","DropDownList","TextBox","TextArea","Captcha","Signature","TimeDurationPicker"],b={hidden:function(t,i){var o=f(i);e('<input type="hidden"/>').attr(o).appendTo(t)},number:function(t,o){var a=f(o);e('<input type="text"/>').attr(a).appendTo(t).kendoNumericTextBox(n({},o.editorOptions,{format:o.format})),e("<span "+i.attr("for")+'="'+o.field+'" class="k-invalid-msg k-hidden"/>').appendTo(t)},date:function(t,o){var a=f(o),r=o.format;r&&(r=i._extractFormat(r)),a[i.attr("format")]=r,e('<input type="text"/>').attr(a).appendTo(t).kendoDatePicker(n({},o.editorOptions,{format:o.format})),e("<span "+i.attr("for")+'="'+o.field+'" class="k-invalid-msg k-hidden"/>').appendTo(t)},string:function(t,i){var o=f(i);e('<input type="text"/>').attr(o).appendTo(t).kendoTextBox(i.editorOptions)},boolean:function(t,i){var o=f(i);g(e('<input type="checkbox" />').attr(o).kendoCheckBox(i.editorOptions).appendTo(t),t,i)},values:function(t,o){var a=f(o),n=i.stringify(function(e){var t,i,o,a,n,r;if(e&&e.length)for(r=[],t=0,i=e.length;t<i;t++)n=(o=e[t]).text||o.value||o,a=null==o.value?o.text||o:o.value,r[t]={text:n,value:a};return r}(o.values));e("<select "+i.attr("text-field")+'="text"'+i.attr("value-field")+'="value"'+i.attr("source")+"='"+(n?n.replace(/\'/g,"&apos;"):n)+"'"+i.attr("size")+'="'+o.editorOptions.size+'"'+i.attr("role")+'="dropdownlist"/>').attr(a).appendTo(t),e("<span "+i.attr("for")+'="'+o.field+'" class="k-invalid-msg  k-hidden"/>').appendTo(t)},kendoEditor:function(t,i){var o=f(i),a=i.editor,n="kendo"+a,r=i.editorOptions,d=function(e,t){if(e.length)return"DropDownTree"===e&&t&&t.checkboxes||"MultiSelect"===e?"<select />":"RadioGroup"===e||"CheckBoxGroup"===e?"<ul />":"Signature"===e?"<div></div>":"Editor"===e||"TextArea"===e?"<textarea />":"<input />"}(a,r);g(e(d).attr(o).appendTo(t)[n](r),t,i)}},x={number:function(t,i){var o=f(i);o=m(t,o),e('<input type="number"/>').attr(o).appendTo(t)},date:function(t,i){var o=f(i);o=m(t,o),e('<input type="date"/>').attr(o).appendTo(t)},string:function(t,i){var o=f(i);o=m(t,o),e('<input type="text" />').attr(o).appendTo(t)},boolean:function(t,i){var o=f(i);o=m(t,o),e('<input type="checkbox" />').attr(o).appendTo(t)},values:function(t,i){var o=f(i),a=i.values,n=e("<select />");for(var r in o=m(t,o),a)e('<option value="'+a[r].value+'">'+a[r].text+"</option>").appendTo(n);n.attr(o).appendTo(t)}};function h(e,t){var i,o,a=e&&e.validation||{};for(i in a)o=a[i],d(o)&&o.value&&(o=o.value),r(o)&&(t[i]=o)}function g(t,i,o){(o&&o.shouldRenderHidden||!1)&&(t.val(!0),i.append(e("<input type='hidden' name='"+o.field+"' value='false' data-skip='true' data-validate='false'/>")))}var y=a.extend({init:function(e,t){var i=this;t.target&&t.target.pane&&(i._isMobile=!0),a.fn.init.call(i,e,t),i._validateProxy=i._validate.bind(i),i.refresh()},events:[p],options:{name:"Editable",editors:b,mobileEditors:x,clearContainer:!0,validateOnBlur:!0,validationSummary:!1,errorTemplate:({message:e})=>'<div class="k-tooltip k-tooltip-error k-validator-tooltip">'+i.ui.icon({icon:"exclamation-circle",iconClass:"k-tooltip-icon"})+`<span class="k-tooltip-content">${e}</span><span class="k-callout k-callout-n"></span></div>`,skipFocus:!1,size:"medium"},editor:function(t,o){var a,r=this,l=r._isMobile?x:r.options.editors,p=d(t),u=p?t.field:t,c=r.options.model||{},f=p&&t.values?"values":v(o),m=p&&"string"==typeof t.editor&&"hidden"===t.editor,b=p&&!m&&t.editor,h=p&&-1!==e.inArray(t.editor,k),g=b?t.editor:l[m?"hidden":f],y=r.element.find("["+i.attr("container-for")+"="+u.replace(s,"\\$1")+"]");g=g||l.string,h?g=l.kendoEditor:b&&"string"==typeof t.editor&&(g=function(e){e.append(t.editor)}),p?(t.editorOptions||(t.editorOptions={}),t.editorOptions=n({},{size:r.options.size},t.editorOptions),a=t):a={field:u,editorOptions:{size:r.options.size}},g(y=y.length?y:r.element,n(!0,{},a,{model:c}))},_validate:function(t){var o,a=this,n=t.value,r=a._validationEventInProgress,d={},l=i.attr("bind"),u=t.field.replace(s,"\\$1"),c=new RegExp("(value|checked)\\s*:\\s*"+u+"\\s*(,|$)");d[t.field]=t.value,(o=e(":input["+l+'*="'+u+'"]',a.element).filter("["+i.attr("validate")+"!='false']").filter((function(){return c.test(e(this).attr(l))}))).length>1&&(o=o.filter((function(){var t=e(this);return!t.is(":radio")||t.val()==n})));try{a._validationEventInProgress=!0,(!a.validatable.validateInput(o)||!r&&a.trigger(p,{values:d}))&&t.preventDefault()}finally{a._validationEventInProgress=!1}},end:function(){return this.validatable.validate()},destroy:function(){var e=this;a.fn.destroy.call(e),e.options.model.unbind("set",e._validateProxy),e.options.model.unbind(u,e._validateProxy),i.unbind(e.element),e.validatable&&e.validatable.destroy(),i.destroy(e.element),e.element.removeData("kendoValidator"),e.element.is("["+i.attr("role")+"=editable]")&&e.element.removeAttr(i.attr("role"))},refresh:function(){var t,o,a,n,r,l,s=this,p=s.options.fields||[],c=s.options.clearContainer?s.element.empty():s.element,v=s.options.model||{},f={};for(Array.isArray(p)||(p=[p]),t=0,o=p.length;t<o;t++)a=p[t],n=d(a)?a.field:a,h(r=(v.fields||v)[n],f),s.editor(a,r);if(!o)for(n in l=v.fields||v)h(l[n],f);!function(t){t.find(":input:not(:button, .k-combobox .k-input, .k-checkbox-list .k-checkbox, .k-radio-list .k-radio, ["+i.attr("role")+"=listbox], ["+i.attr("role")+"=upload], ["+i.attr("skip")+"], [type=file]), ["+i.attr("role")+"=radiogroup]").each((function(){var t=i.attr("bind"),o=this.getAttribute(t)||"",a="checkbox"===this.type||"radio"===this.type?"checked:":"value:",n=this.getAttribute("name")===y.antiForgeryTokenName,r=this.attributes.name&&this.attributes.name.value;-1===o.indexOf(a)&&r&&!n&&(o+=(o.length?",":"")+a+r,e(this).attr(t,o))}))}(c),s.validatable&&s.validatable.destroy(),i.bind(c,s.options.model),s.options.validateOnBlur&&(s.options.model.unbind("set",s._validateProxy).bind("set",s._validateProxy),s.options.model.unbind(u,s._validateProxy).bind(u,s._validateProxy)),s.validatable=new i.ui.Validator(c,{validateOnBlur:s.options.validateOnBlur,validationSummary:s.options.validationSummary,errorTemplate:s.options.errorTemplate||undefined,rules:f}),s.options.skipFocus||c.find(":kendoFocusable").eq(0).trigger("focus")}});y.antiForgeryTokenName="__RequestVerificationToken",o.plugin(y)}(window.kendo.jQuery);
//# sourceMappingURL=kendo.editable.js.map