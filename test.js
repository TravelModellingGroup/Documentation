function handleLinkClicks(event) {

  ga('send', 'event', {
    eventCategory: 'Link',
    eventAction: 'click',
    eventLabel: event.target.href
  });
};


var a = document.getElementsByTagName("a");

for(i = 0; i < a.length; i++){
{
   //a[i].onclick = handleLinkClicks(this);
   console.log(a[i]);
}
