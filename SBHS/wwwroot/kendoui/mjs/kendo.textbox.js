/**
 * Kendo UI v2024.1.130 (http://www.telerik.com/kendo-ui)
 * Copyright 2024 Progress Software Corporation and/or one of its subsidiaries or affiliates. All rights reserved.
 *
 * Kendo UI commercial licenses may be obtained at
 * http://www.telerik.com/purchase/license-agreement/kendo-ui-complete
 * If you do not own a commercial license, this file shall be governed by the trial license terms.
 */
import"./kendo.core.js";import"./kendo.floatinglabel.js";import"./kendo.icons.js";let $=kendo.jQuery;function addInputPrefixSuffixContainers({widget:e,wrapper:t,options:n,prefixInsertBefore:a,suffixInsertAfter:i}){var l,o,s=n.prefixOptions,r=n.suffixOptions,p=s.template||s.icon,d=r.template||r.icon,u=(i=i||a,n.layoutFlow),f=u?"vertical"==u?"horizontal":"vertical":"horizontal",c=`<span class="k-input-separator k-input-separator-${"vertical"==u?"horizontal":"vertical"}"></span>`;s&&p&&((l=t.children(".k-input-prefix"))[0]||(l=$(`<span class="k-input-prefix k-input-prefix-${f}" />`),a?l.insertBefore(a):l.prependTo(t)),s.icon&&l.html(kendo.html.renderIcon({icon:s.icon})),s.template&&l.html(kendo.template(s.template)({})),s.separator&&$(c).insertAfter(l)),r&&d&&((o=t.children(".k-input-suffix"))[0]||(o=$(`<span class="k-input-suffix k-input-suffix-${f}" />`).appendTo(t),i?o.insertAfter(i):o.appendTo(t)),r.icon&&o.html(kendo.html.renderIcon({icon:r.icon})),r.template&&o.html(kendo.template(r.template)({})),r.separator&&$(c).insertBefore(o)),e._prefixContainer=l,e._suffixContainer=o}var __meta__={id:"textbox",name:"TextBox",category:"web",description:"The TextBox widget enables you to style and provide a floating label functionality to input elements",depends:["core","floatinglabel","icons"]};!function(e,t){var n=window.kendo,a=n.ui.Widget,i=n.ui,l=e.isPlainObject,o=".kendoTextBox",s="change",r="disabled",p="readonly",d="k-input-inner",u="input",f="k-focus",c="k-disabled",b="k-no-click",h="aria-disabled",m=a.extend({init:function(i,l){var o=this;a.fn.init.call(o,i,l),l=e.extend(!0,{},l),o.options.value=l.value||o.element.val(),o.options.readonly=l.readonly!==t?l.readonly:Boolean(o.element.attr("readonly")),o.options.enable=l.enable!==t?l.enable:!Boolean(o.element.attr("disabled")),o.options.placeholder=l.placeholder||o.element.attr("placeholder"),o.value(o.options.value),o._wrapper(),o._label(),o._editable({readonly:o.options.readonly,disable:!o.options.enable}),o.element.addClass(d).attr("placeholder",o.options.placeholder).attr("autocomplete","off"),l.icon&&o._icon(),addInputPrefixSuffixContainers({widget:o,wrapper:o.wrapper,options:o.options}),n.notify(o),o._applyCssClasses(),o.floatingLabel&&o.floatingLabel.refresh()},events:[s,u],options:{name:"TextBox",value:"",readonly:!1,enable:!0,placeholder:"",label:null,rounded:"medium",size:"medium",fillMode:"solid",icon:null,prefixOptions:{separator:!0},suffixOptions:{separator:!0}},value:function(e){var n=this;if(e===t)return n._value;n._value=e,n.element.val(e),n.floatingLabel&&n.floatingLabel.refresh()},readonly:function(e){this._editable({readonly:e===t||e,disable:!1}),this.floatingLabel&&this.floatingLabel.readonly(e===t||e)},enable:function(e){this._editable({readonly:!1,disable:!(e=e===t||e)}),this.floatingLabel&&this.floatingLabel.enable(e=e===t||e)},focus:function(){this.element[0].focus()},destroy:function(){var e=this;e.floatingLabel&&e.floatingLabel.destroy(),e.element.off(o),e.element[0].style.width="",e.element.removeClass(d),a.fn.destroy.call(e)},setOptions:function(e){this.destroy(),this._inputLabel&&(this._inputLabel.remove(),this._inputLabel=null),this._floatingLabelContainer?(this.floatingLabel.destroy(),this.floatingLabel=null,this.element.unwrap(),this.element.unwrap(),this._floatingLabelContainer=null):this.element.unwrap(),n.deepExtend(this.options,e),this.init(this.element,this.options)},_editable:function(e){var t=this,n=t.element,a=t.wrapper,i=e.disable,l=e.readonly;n.off(o),l||i?(n.attr(r,i).attr(p,l).attr(h,i),a.toggleClass(c,i).toggleClass(b,l)):(n.prop(r,!1).prop(p,!1).attr(h,!1),a.removeClass(c).removeClass(b),n.on("focusin"+o,t._focusin.bind(t)),n.on("focusout"+o,t._focusout.bind(t)),n.on("change"+o,t._change.bind(t)),n.on(u+o,t._input.bind(t)))},_icon:function(){this.wrapper.prepend(n.ui.icon({icon:this.options.icon,iconClass:"k-input-icon"}))},_input:function(e){var t=this.element.val();this.trigger(u,{value:t,originalEvent:e})},_label:function(){var t,a,i=this,o=i.element,s=i.options,r=o.attr("id");null!==s.label&&(t=!!l(s.label)&&s.label.floating,a=l(s.label)?s.label.content:s.label,t&&(i._floatingLabelContainer=i.wrapper.wrap("<span></span>").parent(),i.floatingLabel=new n.ui.FloatingLabel(i._floatingLabelContainer,{widget:i})),n.isFunction(a)&&(a=a.call(i)),a||(a=""),r||(r=s.name+"_"+n.guid(),o.attr("id",r)),i._inputLabel=e("<label class='k-label k-input-label' for='"+r+"'>"+a+"</label>'").insertBefore(i.wrapper))},_focusin:function(){this.wrapper.addClass(f)},_focusout:function(){this.wrapper.removeClass(f)},_change:function(e){var t=this,n=t.element.val();t._value=n,t.trigger(s,{value:n,originalEvent:e})},_wrapper:function(){var e,t=this.element,n=t[0];(e=t.wrap("<span class='k-input k-textbox'></span>").parent())[0].style.cssText=n.style.cssText,n.style.width="100%",this.wrapper=e.addClass(n.className).removeClass("input-validation-error")}});n.cssProperties.registerPrefix("TextBox","k-input-"),n.cssProperties.registerValues("TextBox",[{prop:"rounded",values:n.cssProperties.roundedValues.concat([["full","full"]])}]),i.plugin(m)}(window.kendo.jQuery);var kendo$1=kendo;export{kendo$1 as default};
//# sourceMappingURL=kendo.textbox.js.map