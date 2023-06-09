const btn1=document.querySelectorAll(".btn")
var lbl = document.getElementById("changes");
btn1.forEach(button => {

    button.addEventListener('click', () => {
      
        if (button.innerText == 'Showtext') {

            lbl.innerHTML = "<p>Hello World</p>";

        }
        if (button.innerText == 'Bold') {

            lbl.style.fontWeight='bold'

        }
        if (button.innerText == 'Italic') {
            lbl.style.fontStyle = 'italic'

        }
        if (button.innerText == 'Underline') {
            //document.getElementById("changes").innerytext;
            lbl.style.textDecoration='underline'

        }
        if (button.innerText == 'Reset') {

            lbl.style = 'none';

            lbl.innerHTML = "<p>Changes should be shown here</p>";


        }



    });

});