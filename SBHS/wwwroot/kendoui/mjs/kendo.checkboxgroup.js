/**
 * Kendo UI v2024.1.130 (http://www.telerik.com/kendo-ui)
 * Copyright 2024 Progress Software Corporation and/or one of its subsidiaries or affiliates. All rights reserved.
 *
 * Kendo UI commercial licenses may be obtained at
 * http://www.telerik.com/purchase/license-agreement/kendo-ui-complete
 * If you do not own a commercial license, this file shall be governed by the trial license terms.
 */
import"./kendo.core.js";import"./kendo.inputgroupbase.js";import"./kendo.checkbox.js";var __meta__={id:"checkboxgroup",name:"CheckBoxGroup",category:"web",description:"The CheckBoxGroup component.",depends:["core","inputgroupbase","checkbox"]};!function(e,t){var i=window.kendo,n=i.ui,o=n.InputGroupBase,r="checked",u=o.extend({options:{name:"CheckBoxGroup",inputName:"",inputRounded:"medium",inputSize:"medium",enabled:!0,labelPosition:"after",layout:"vertical",items:[]},ITEM_TEMPLATE:'<li class="k-checkbox-item"><input type="checkbox" class="k-checkbox" ></li>',NS:".kendoCheckBoxGroup",COMPONENT:"kendoCheckBox",groupStyles:{item:"k-checkbox-item",input:"k-checkbox",label:"k-checkbox-label",list:"k-checkbox-list",vertical:"k-list-vertical",horizontal:"k-list-horizontal",disabled:"k-disabled"},checkAll:function(e){var t=this,i=t.element.find("input");!0===e?(i.prop(r,!0),t._value=[],i.each((function(e,i){t._value.push(i.value)}))):!1===e&&(i.prop(r,!1),t._value=[])},value:function(e){var t,i,n,o,u=this,a=[];if(undefined===e)return u._value||(u._value=[]),u._value;if(null===e||0===e.length)return u._value=[],void u.element.find("."+u.groupStyles.input).prop(r,!1);if(e&&!(e.length<1)){for((i=u.element.find("input[value='"+e[0]+"']")).length&&a.push(e[0]),o=1;o<e.length;o++)t=u.element.find("input[value='"+e[o]+"']"),(n=i.add(t)).length>i.length&&(i=n,a.push(e[o]));u._value=a,u.element.find("."+u.groupStyles.input).prop(r,!1),i.prop(r,!0)}},_changeHandler:function(t){var i=e(t.target),n=i.val();this._targetForPreventedChange!==t.target?(this._value||(this._value=[]),i.is(":checked")?this._value.push(n):this._value=this._value.filter((function(e){return e!==n})),this.trigger("change",{target:i})):this._targetForPreventedChange=null},_dataValRequired:function(e){e["data-msg-required"]=this.wrapper.attr("data-val-required"),e["data-rule-required"]="true"}});i.cssProperties.registerPrefix("CheckBoxGroup","k-checkbox-"),i.cssProperties.registerValues("CheckBoxGroup",[{prop:"rounded",values:i.cssProperties.roundedValues.concat([["full","full"]])}]),n.plugin(u)}(window.kendo.jQuery);var kendo$1=kendo;export{kendo$1 as default};
//# sourceMappingURL=kendo.checkboxgroup.js.map
