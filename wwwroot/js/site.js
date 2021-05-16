const initialState = { count: 0 };
function reducer(state, action) {
    switch (action.type) {
        case 'increment':
            return { count: state.count + 1 };
        case 'decrement':
            return { count: state.count - 1 };
        default:
            throw new Error();
    }
}
function Example() {
    // Объявляем новую переменную состояния "count"
    //const [count, setCount] = React.useState(0);
    const [state, dispatch] = React.useReducer(reducer, initialState);
    return (React.createElement("div", null,
        "Count: ",
        state.count,
        React.createElement("button", { onClick: () => dispatch({ type: 'decrement' }) }, "-"),
        React.createElement("button", { onClick: () => dispatch({ type: 'increment' }) }, "+")));
}
ReactDOM.render(React.createElement(Example), document.getElementById("myApp"));
