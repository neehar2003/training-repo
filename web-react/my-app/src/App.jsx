import Header from "./components/Header";
import ListItem from "./components/ListItem";
function App(){
  return <div>
    <Header title ="Fruits" count={5} />
    <Header title="Vegetables"/>
    <ul>
      <ListItem name="Apple" />
      <ListItem name="Banana" />
      <ListItem name="Watermelon" />
    </ul>
  </div>
}
export default App