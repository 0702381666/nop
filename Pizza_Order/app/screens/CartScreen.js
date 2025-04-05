import React, { useContext } from 'react';
import {
  View, Text, FlatList, TouchableOpacity, Image, StyleSheet, ScrollView
} from 'react-native';
import { CartContext } from '../context/CartContext';
import { Ionicons } from '@expo/vector-icons';

const CartScreen = () => {
  const { cartItems, setCartItems } = useContext(CartContext);

  const handleQuantityChange = (index, delta) => {
    const updatedItems = [...cartItems];
    updatedItems[index].quantity += delta;
    if (updatedItems[index].quantity < 1) return;
    updatedItems[index].total =
      (updatedItems[index].selectedSize.price +
        updatedItems[index].addons.reduce((sum, a) => sum + a.price, 0)) *
      updatedItems[index].quantity;

    setCartItems(updatedItems);
  };

  const handleRemove = (index) => {
    const updatedItems = cartItems.filter((_, i) => i !== index);
    setCartItems(updatedItems);
  };

  const grandTotal = cartItems.reduce((sum, item) => sum + item.total, 0);

  return (
    <View style={styles.container}>
      <Text style={styles.title}>Your Basket</Text>

      <FlatList
        data={cartItems}
        keyExtractor={(_, index) => index.toString()}
        contentContainerStyle={{ paddingBottom: 100 }}
        renderItem={({ item, index }) => (
          <View style={styles.card}>
            <Image source={{ uri: item.product.image }} style={styles.image} />
            <View style={{ flex: 1 }}>
              <View style={styles.rowSpace}>
                <Text style={styles.name}>
                  {item.product.name} ({item.selectedSize.label})
                </Text>
                <TouchableOpacity onPress={() => handleRemove(index)}>
                  <Ionicons name="trash-outline" size={20} color="gray" />
                </TouchableOpacity>
              </View>
              <Text style={styles.addonText}>
                Add-ons: {item.addons.map(a => a.label).join(', ') || 'None'}
              </Text>
              <Text style={styles.price}>${item.total.toFixed(2)}</Text>

              <View style={styles.qtyRow}>
                <TouchableOpacity onPress={() => handleQuantityChange(index, -1)} style={styles.qtyBtn}>
                  <Text style={styles.qtyText}>-</Text>
                </TouchableOpacity>
                <Text style={styles.qtyText}>{item.quantity}</Text>
                <TouchableOpacity onPress={() => handleQuantityChange(index, 1)} style={styles.qtyBtn}>
                  <Text style={styles.qtyText}>+</Text>
                </TouchableOpacity>
              </View>
            </View>
          </View>
        )}
      />

      {/* Footer */}
      <View style={styles.footer}>
        <Text style={styles.totalLabel}>Total:</Text>
        <Text style={styles.totalAmount}>${grandTotal.toFixed(2)}</Text>
        <TouchableOpacity style={styles.checkoutBtn}>
          <Text style={{ color: 'white', fontWeight: 'bold' }}>Checkout</Text>
        </TouchableOpacity>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: { flex: 1, backgroundColor: '#fff', paddingTop: 50 },
  title: { fontSize: 22, fontWeight: 'bold', margin: 16 },
  card: {
    flexDirection: 'row',
    marginHorizontal: 16,
    marginBottom: 12,
    backgroundColor: '#f9f9f9',
    padding: 12,
    borderRadius: 12,
    gap: 12,
  },
  image: { width: 70, height: 70, borderRadius: 8 },
  name: { fontWeight: '600', fontSize: 16, flexShrink: 1 },
  addonText: { color: 'gray', marginTop: 2 },
  price: { color: 'green', fontWeight: 'bold', marginTop: 6 },
  rowSpace: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
  },
  qtyRow: {
    flexDirection: 'row',
    alignItems: 'center',
    marginTop: 10,
  },
  qtyBtn: {
    backgroundColor: '#eee',
    paddingHorizontal: 12,
    paddingVertical: 6,
    borderRadius: 6,
    marginHorizontal: 12,
  },
  qtyText: { fontSize: 16, fontWeight: 'bold' },
  footer: {
    position: 'absolute',
    bottom: 0,
    left: 0,
    right: 0,
    backgroundColor: '#fff',
    padding: 16,
    borderTopWidth: 1,
    borderTopColor: '#eee',
    alignItems: 'center',
  },
  totalLabel: { fontSize: 16 },
  totalAmount: { fontSize: 18, fontWeight: 'bold', color: 'green', marginVertical: 6 },
  checkoutBtn: {
    backgroundColor: 'green',
    paddingHorizontal: 32,
    paddingVertical: 12,
    borderRadius: 10,
    marginTop: 8,
  },
});

export default CartScreen;
