import { useState } from "react";
import Header from "./components/Header";
import ListItem from "./components/ListItem";
function App(){
  const [count, setCount] = useState(0)
  return (
  <div>
    <Header title="Fruits" count={5} />
    <Header title="Vegetables"/>
    <ul>
      <ListItem name="Apple" />
      <ListItem name="Banana" />
      <ListItem name="Watermelon" />
    </ul>
    <p>{count}</p>
    <button onClick={()=> setCount(count+1)}>
      Increment
    </button>
    <button onClick={()=> setCount(count-1)}>
      Decrement
    </button>
    <button onClick={()=> setCount(0)}>
      Reset
    </button>
  </div>
  )
}
export default App