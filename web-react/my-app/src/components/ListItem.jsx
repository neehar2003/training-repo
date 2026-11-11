function ListItem({ name, onDelete }){
    return (
        <li className="item">
            {name}
            <button onClick={onDelete}>Delete</button>
        </li>
    )
}
export default ListItem
