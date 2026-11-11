import { useState } from "react";
import Header from "./components/Header";
import ListItem from "./components/ListItem";
function App(){
  const [text, setText] = useState("")
  const [items, setItems] = useState([
    { id: 1, name: "Apple" },
    { id: 2, name: "Banana" },
    { id: 3, name: "Watermelon" },
    { id: 4, name: "Mango" },
  ])
  function handleAdd(){
    /* strips whitespaces */
    if(text.trim()==="")return
    setItems([...items, {id:Date.now(), name: text}])
    setText("")
  }
  function handleDelete(id){
    setItems(items.filter(item => item.id !== id))
  }
  return (
  <div>
    <Header title="Fruits" count={items.length} />
    <ul>
      {items.map(item => <ListItem
      key={item.id}
      name={item.name}
      onDelete={()=> handleDelete(item.id)}
       />)}
    </ul>
    <input 
      value={text} 
      onChange={(e) => setText(e.target.value)} />
      <button onClick={handleAdd}>Add</button>
  </div>
  )
}
export default App