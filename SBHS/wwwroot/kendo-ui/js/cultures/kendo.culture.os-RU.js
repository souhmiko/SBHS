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
(function (factory) {
    typeof define === 'function' && define.amd ? define(['kendo.core'], factory) :
    factory();
})((function () {
    (function( window, undefined$1 ) {
        kendo.cultures["os-RU"] = {
            name: "os-RU",
            numberFormat: {
                pattern: ["-n"],
                decimals: 2,
                ",": " ",
                ".": ",",
                groupSize: [3],
                percent: {
                    pattern: ["-n%","n%"],
                    decimals: 2,
                    ",": " ",
                    ".": ",",
                    groupSize: [3],
                    symbol: "%"
                },
                currency: {
                    name: "Russian Ruble",
                    abbr: "RUB",
                    pattern: ["-$ n","$ n"],
                    decimals: 2,
                    ",": " ",
                    ".": ",",
                    groupSize: [3],
                    symbol: "₽"
                }
            },
            calendars: {
                standard: {
                    days: {
                        names: ["хуыцаубон","къуырисӕр","дыццӕг","ӕртыццӕг","цыппӕрӕм","майрӕмбон","сабат"],
                        namesAbbr: ["хцб","крс","дцг","ӕрт","цпр","мрб","сбт"],
                        namesShort: ["хцб","крс","дцг","ӕрт","цпр","мрб","сбт"]
                    },
                    months: {
                        names: ["Январь","Февраль","Мартъи","Апрель","Май","Июнь","Июль","Август","Сентябрь","Октябрь","Ноябрь","Декабрь"],
                        namesAbbr: ["Янв.","Февр.","Март.","Апр.","Май","Июнь","Июль","Авг.","Сент.","Окт.","Нояб.","Дек."]
                    },
                    AM: ["AM","am","AM"],
                    PM: ["PM","pm","PM"],
                    patterns: {
                        d: "dd.MM.yyyy",
                        D: "dddd, d MMMM, yyyy 'аз'",
                        F: "dddd, d MMMM, yyyy 'аз' HH:mm:ss",
                        g: "dd.MM.yyyy HH:mm",
                        G: "dd.MM.yyyy HH:mm:ss",
                        m: "MMMM d",
                        M: "MMMM d",
                        s: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
                        t: "HH:mm",
                        T: "HH:mm:ss",
                        u: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
                        y: "yyyy MMMM",
                        Y: "yyyy MMMM"
                    },
                    "/": ".",
                    ":": ":",
                    firstDay: 1
                }
            }
        };
    })();

}));
