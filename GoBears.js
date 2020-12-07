function GoBears(){
  for(let i = 1; i <= 100; i ++){
    if(i % 5 == 0 && i % 3 == 0){
      console.log("MSUBears")
    }
    if(i % 5 == 0) {
      console.log("Bears")
    }
    if(i % 3 == 0) {
      console.log("MSU")
    }
    else {
      console.log(i)
    }
  }
}

GoBears()
