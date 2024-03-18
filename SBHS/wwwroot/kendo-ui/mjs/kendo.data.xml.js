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
import"./kendo.core.js";var __meta__={id:"data.xml",name:"XML",category:"framework",depends:["core"],hidden:!0};!function(e,t){var r=window.kendo,n=Array.isArray,a=e.isPlainObject,i=e.map,o=e.each,d=e.extend,f=r.getter,l=r.Class.extend({init:function(e){var t=this,f=e.total,l=e.model,s=e.parse,u=e.errors,p=e.serialize,c=e.data;if(l){if(a(l)){var m=e.modelBase||r.data.Model;l.fields&&o(l.fields,(function(e,n){a(n)&&n.field?r.isFunction(n.field)||(n=d(n,{field:t.getter(n.field)})):n={field:t.getter(n)},l.fields[e]=n}));var h=l.id;if(h){var x={};x[t.xpathToMember(h,!0)]={field:t.getter(h)},l.fields=d(x,l.fields),l.id=t.xpathToMember(h)}l=m.define(l)}t.model=l}if(f&&("string"==typeof f?(f=t.getter(f),t.total=function(e){return parseInt(f(e),10)}):"function"==typeof f&&(t.total=f)),u&&("string"==typeof u?(u=t.getter(u),t.errors=function(e){return u(e)||null}):"function"==typeof u&&(t.errors=u)),c&&("string"==typeof c?(c=t.xpathToMember(c),t.data=function(e){var r,a=t.evaluate(e,c);return a=n(a)?a:[a],t.model&&l.fields?(r=new t.model,i(a,(function(e){if(e){var t,n={};for(t in l.fields)n[t]=r._parse(t,l.fields[t].field(e));return n}}))):a}):"function"==typeof c&&(t.data=c)),"function"==typeof s){var v=t.parse;t.parse=function(e){var r=s.call(t,e);return v.call(t,r)}}"function"==typeof p&&(t.serialize=p)},total:function(e){return this.data(e).length},errors:function(e){return e?e.errors:null},serialize:function(e){return e},parseDOM:function(e){var t,r,a,i,o,d,f,l={},s=e.attributes,u=s.length;for(f=0;f<u;f++)l["@"+(d=s[f]).nodeName]=d.nodeValue;for(r=e.firstChild;r;r=r.nextSibling)3===(a=r.nodeType)||4===a?l["#text"]=r.nodeValue:1===a&&(t=this.parseDOM(r),o=l[i=r.nodeName],n(o)?o.push(t):o=undefined!==o?[o,t]:t,l[i]=o);return l},evaluate:function(e,t){for(var r,a,i,o,d,f=t.split(".");r=f.shift();)if(e=e[r],n(e)){for(a=[],t=f.join("."),d=0,i=e.length;d<i;d++)o=this.evaluate(e[d],t),o=n(o)?o:[o],a.push.apply(a,o);return a}return e},parse:function(t){var r,n,a={};return r=t.documentElement||e.parseXML(t).documentElement,n=this.parseDOM(r),a[r.nodeName]=n,a},xpathToMember:function(e,t){return e?(e=e.replace(/^\//,"").replace(/\//g,".")).indexOf("@")>=0?e.replace(/\.?(@.*)/,t?"$1":'["$1"]'):e.indexOf("text()")>=0?e.replace(/(\.?text\(\))/,t?"#text":'["#text"]'):e:""},getter:function(e){return f(this.xpathToMember(e),!0)}});e.extend(!0,r.data,{XmlDataReader:l,readers:{xml:l}})}(window.kendo.jQuery);var kendo$1=kendo;export{kendo$1 as default};
//# sourceMappingURL=kendo.data.xml.js.map
