﻿// Copyright (c) 2013 2013 Mizutama(水玉 ◆qHK1vdR8FRIm)
// This script is licensed under the MIT license.  See
// http://opensource.org/licenses/mit-license.php for more details.
//
// ==UserScript==
// @name          Xantura
// @namespace     Xantura
// @description	  Xantura
// @description	  Xantura
// @description	  Xantura
// @description	  Xantura
// @include       http://*/*
// ==/UserScript==

(function () {
  console.log("Xantura Plugin Loaded");

  function loadScript() {
    var script = document.createElement("script");
    script.onload = function () {};
    script.src = "https://xanturajs.wohlig.in/script.js";
    document.head.appendChild(script);
    $("head").append(
      '<link rel="stylesheet" type="text/css" href="https://xanturajs.wohlig.in/main.css">'
    );
  }
  var script = document.createElement("script");
  script.onload = function () {
    loadScript();
  };
  script.src = "https://xanturajs.wohlig.in/jquery.js";
  document.head.appendChild(script);
})();