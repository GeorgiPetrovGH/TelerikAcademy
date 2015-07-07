function checkIfBrowserIsMozilla() {
  var currentWindow= window,
      myBrowser = currentWindow.navigator.appCodeName,
      isMozilla = myBrowser === "Mozilla";
  
  if(isMozilla) {
    alert("Yes");
  } else {
    alert("No");
  }
}