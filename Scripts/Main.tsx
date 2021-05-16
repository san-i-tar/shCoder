

const initialState = { count: 0 };

function reducer(state, action) {
  switch (action.type) {
    case 'increment':
      return {count: state.count + 1};
    case 'decrement':
      return {count: state.count - 1};
    default:
      throw new Error();
  }
}


function Example() {
        // Объявляем новую переменную состояния "count"
        //const [count, setCount] = React.useState(0);
        const [state, dispatch] = React.useReducer(reducer, initialState);

        return (
            <div>
                
                Count: {state.count}
                <button onClick={() => dispatch({ type: 'decrement' })}>-</button>
                <button onClick={() => dispatch({ type: 'increment' })}>+</button>
                {/*<p>Вы нажали {count} раз</p>*/}
                {/*<button onClick={() => setCount(count + 1)}>*/}
                {/*    Нажми на меня*/}
                {/*</button>*/}
            </div>
        );
}

ReactDOM.render(React.createElement(Example), document.getElementById("myApp"));